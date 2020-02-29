using UnityEngine;
using XWindows.Events;

namespace XWindows
{

    [RequireComponent(typeof(CanvasGroup))]
    public class Window : MonoBehaviour, IWindow
    {
        private CanvasGroup m_CanvasGroup;

        #region INITIALIZATION

        private void Awake()
        {
            m_CanvasGroup = GetComponent<CanvasGroup>();

            m_OnShowedUpEvent = new Events.Event();
            m_OnHidedUpUpEvent = new Events.Event();
        }

        #endregion

        #region WINDOW

        public void Show()
        {
            //Debug.LogErrorFormat("Show {0}", gameObject.name);
            m_CanvasGroup.alpha = 1;
            m_CanvasGroup.interactable = true;
            m_CanvasGroup.blocksRaycasts = true;

            m_OnShowedUpEvent.Execute();
        }

        public void Hide()
        {
            //Debug.LogErrorFormat("Hide {0}", gameObject.name);
            m_CanvasGroup.alpha = 0;
            m_CanvasGroup.interactable = false;
            m_CanvasGroup.blocksRaycasts = false;

            m_OnHidedUpUpEvent.Execute();
        }

        public void Lock()
        {
            m_CanvasGroup.interactable = false;
        }

        public void Unlock()
        {
            m_CanvasGroup.interactable = true;
        }

        #endregion

        #region EVENTS

        private Events.Event m_OnShowedUpEvent;
        public IListenable OnShowedUp { get { return m_OnShowedUpEvent; } }

        private Events.Event m_OnHidedUpUpEvent;
        public IListenable OnHidedUp { get { return m_OnHidedUpUpEvent; } }

        #endregion
    }
}