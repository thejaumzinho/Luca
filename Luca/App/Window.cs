using OpenTK.Windowing.Desktop;

namespace Luca.App;

public class Window : GameWindow
{
    public Window() : base(GameWindowSettings.Default, NativeWindowSettings.Default)
    {
        Title = "Luca";
    }
}
