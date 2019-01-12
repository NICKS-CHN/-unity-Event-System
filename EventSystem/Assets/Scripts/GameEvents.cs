using UnityEngine;
using System.Collections;


/// <summary>
/// 定义事件
/// </summary>
public class GameEvents
{
    public class Event
    {
        public readonly string eventName;
        public Event(string mEventname)
        {
            eventName = mEventname;
        }
    }

    public class Event<T>
    {
        public readonly string eventName;
        public Event(string mEventname)
        {
            eventName = mEventname;
        }
    }
    public class Event<T1, T2>
    {
        public readonly string eventName;
        public Event(string mEventname)
        {
            eventName = mEventname;
        }
    }
    public class Event<T1, T2, T3>
    {
        public readonly string eventName;
        public Event(string mEventname)
        {
            eventName = mEventname;
        }
    }
    public class Event<T1, T2, T3, T4>
    {
        public readonly string eventName;
        public Event(string mEventname)
        {
            eventName = mEventname;
        }
    }
}
