namespace PantheonAddonFramework.Components;

public interface IAddonTextComponent
{
    string GetText();
    void SetText(string text);
    void SetSize(float width, float height);
}