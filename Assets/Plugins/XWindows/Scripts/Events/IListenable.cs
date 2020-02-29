using System;

namespace XWindows.Events
{
    public interface IListenable
    {
        void AddListener(Action listener);
        void RemoveListener(Action listener);
    }

    public interface IListenable<TParam>
    {
        void AddListener(Action<TParam> listener);
        void RemoveListener(Action<TParam> listener);
    }
}