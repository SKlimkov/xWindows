namespace XWindows
{
    public interface IWindowContext
    {
        void Show(IShowData data);
        void Hide(IHideData data);

        string WindowId { get; }
    }
}