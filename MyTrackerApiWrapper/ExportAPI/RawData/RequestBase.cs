using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Markup;
using MyTrackerApiWrapper.Attributes;
using MyTrackerApiWrapper.DataTypes;
using MyTrackerApiWrapper.Helpers;
using MyTrackerApiWrapper.Interfaces;

namespace MyTrackerApiWrapper.ExportAPI.RawData;

public abstract class RequestBase
{
    internal virtual string Path { get; }
    
    
    public IEnumerable<KeyValuePair<string, string>> GetQuery()
    {
        var query = new List<KeyValuePair<string, string>>();
        HandleInstance(this, query);
        return query;
    }

    private void HandleInstance(object instance, ICollection<KeyValuePair<string, string>> query)
    {
        if (instance is null)
            return;

        var properties = GetInitializedProperties(instance);
        foreach (var property in properties)
        {
            HandleProperty(instance, property, query);
        }
    }
    
    private static PropertyInfo[] GetInitializedProperties(object instance)
    {
        if (instance is null)
            return null;

        return instance.GetType()
            .GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(x => ReflectionHelpers.IsInitialized(x.GetValue(instance)))
            .ToArray();
    }

    private void HandleProperty(object instance, PropertyInfo property, ICollection<KeyValuePair<string, string>> query)
    {
        var type = property.PropertyType;
        
        if (property.PropertyType.GetInterfaces().Contains(typeof(IRequestElement)))
        {
            HandleInstance(property.GetValue(instance), query);
            return;
        }
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(ICollection<>))
        {
            HandleCollection(instance, property, query);
            return;
        }

        var name = property.GetCustomAttribute<QueryNameAttribute>()?.Get() ?? property.Name;
        if (property.GetValue(instance) is UnixTimestamp timestamp)
        {
            query.Add(new KeyValuePair<string, string>(name, timestamp.ToString()));
            return;
        }

        if (property.GetValue(instance) is DateOnly date)
        {
            query.Add(new KeyValuePair<string, string>(name, date.ToString("yyyy-MM-dd")));
            return;
        }

        var value = GetQueryValue(property.GetValue(instance));
        
        query.Add(new KeyValuePair<string, string>(name, value));
    }

    private void HandleCollection(object instance, PropertyInfo property, ICollection<KeyValuePair<string, string>> query)
    {
        // Check if has custom name
        var name = property.GetCustomAttribute<QueryNameAttribute>()?.Get() ?? property.Name;

        // Check if is custom array
        var isCustomArray = property.GetCustomAttributes<QueryCustomArray>().Any();
        var isInlineArray = property.GetCustomAttributes<QueryInlineArrayAttribute>().Any();
        if (isCustomArray)
            name += "[]";
        var collection = (ICollection)property.GetValue(instance);

        var values = (from object element in collection! select GetQueryValue(element)).ToList();

        if (isInlineArray)
        {
            query.Add(new KeyValuePair<string, string>(name, string.Join(',', values)));
            return;
        }

        foreach (var value in values)
        {
            query.Add(new KeyValuePair<string, string>(name, value));
        }
    }

    private static string GetQueryValue(object obj)
    {
        var memberInfo = obj.GetType().GetMember(obj.ToString()!).FirstOrDefault();
        if (memberInfo is null)
        {
            return obj.ToString();
        }

        var value = memberInfo.GetCustomAttribute<QueryValueAttribute>()?.Get();
        if (value is null && obj is Enum enumObj)
        {
            return enumObj.ToString("D");
        }

        return value ?? obj.ToString();
    }
}