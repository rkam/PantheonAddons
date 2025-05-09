namespace PantheonAddonFramework.AddonComponents;

public interface ILogger
{
    public void Debug(string message);
    public void Info(string message);
    public void Warn(string message);
    public void Error(string message);
}