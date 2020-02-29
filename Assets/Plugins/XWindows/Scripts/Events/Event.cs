using System;

namespace XWindows.Events
{
    public class Event : IListenable, IExecutable
    {
        private event Action eventInstane;
        public void AddListener(Action listener)
        {
            eventInstane += listener;
        }

        public void RemoveListener(Action listener)
        {
            eventInstane -= listener;
        }

        public void Execute()
        {
            if (eventInstane != null)
            {
                eventInstane();
            }
        }
    }

    public class Event<TParam> : IListenable<TParam>, IExecutable<TParam>
    {
        private event Action<TParam> eventInstane;
        public void AddListener(Action<TParam> listener)
        {
            eventInstane += listener;
        }

        public void RemoveListener(Action<TParam> listener)
        {
            eventInstane -= listener;
        }

        public void Execute(TParam param)
        {
            if (eventInstane != null)
            {
                eventInstane(param);
            }
        }
    }
}
