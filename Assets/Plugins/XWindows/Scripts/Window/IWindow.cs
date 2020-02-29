using XWindows.Events;

namespace XWindows
{
    public interface IWindow : IShowable, IHideable, ILockable
    {
        IListenable OnShowedUp { get; }
        IListenable OnHidedUp { get; }
    }
}