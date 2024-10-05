namespace RawExportApiClient.Interfaces;

public interface ILogger
{
    void Info(string message, params object[] parameters);
    void Error(string message, params object[] parameters);
}