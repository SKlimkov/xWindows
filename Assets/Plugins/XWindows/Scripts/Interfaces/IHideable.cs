namespace XWindows
{
    public interface IHideable
    {
        void Hide();
    }

    public interface IHideable<TConfig>
    {
        void Hide(TConfig config);
    }
}