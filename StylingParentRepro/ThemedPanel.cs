using Avalonia.Controls;
using Avalonia.Styling;

namespace StylingParentRepro
{
    public class ThemedPanel : Panel, IStyleHost
    {
        IStyleHost? IStyleHost.StylingParent => null;
    }
}
