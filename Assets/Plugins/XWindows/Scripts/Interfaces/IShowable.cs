namespace XWindows
{
    public interface IShowable
    {
        void Show();
    }

    public interface IShowable<TConfig>
    {
        void Show(TConfig config);
    }
}