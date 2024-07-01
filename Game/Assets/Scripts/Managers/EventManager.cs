using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum EventType
{
    START,
    PAUSE,
    CONTINUE,
    STOP,
}

public class EventManager
{
    private static readonly IDictionary<EventType, UnityEvent> dictionary = 
        new Dictionary<EventType, UnityEvent>();

    public static void Subscribe(EventType eventType, UnityAction listener)
    {
        UnityEvent unityevent = null;

        if (dictionary.TryGetValue(eventType, out unityevent))
        {
            unityevent.AddListener(listener);
        }
        else
        {
            unityevent = new UnityEvent();
            unityevent.AddListener(listener);
            dictionary.Add(eventType, unityevent);
        }
    }

    public static void Unsubscribe(EventType eventType, UnityAction listener)
    {
        UnityEvent unityevent = null;

        if (dictionary.TryGetValue(eventType, out unityevent)) {
            unityevent.RemoveListener(listener);
        }
    }

    public static void Publish(EventType eventType) {
        UnityEvent unityevent = null;

        if (dictionary.TryGetValue(eventType,out unityevent))
        {
            unityevent.Invoke();
        }
    }
}
