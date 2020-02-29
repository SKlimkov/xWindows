namespace XWindows.Events
{
    public interface IExecutable
    {
        void Execute();
    }

    public interface IExecutable<TParam>
    {
        void Execute(TParam param);
    }
}