namespace XWindows
{
    public interface IWindowManager
    {
        void RegisterWindow(string windowId, IWindowContext window);
        void UnRegisterWindow(string windowId);
    }
}