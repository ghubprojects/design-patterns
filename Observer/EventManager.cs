namespace Observer;

public class EventManager {
    private readonly Dictionary<string, List<IEventListener>> listenersDict = [];

    public void Subscribe(string eventType, IEventListener listener) {
        if (!listenersDict.TryGetValue(eventType, out List<IEventListener>? listeners)) {
            listenersDict[eventType] = listeners = [];
        }
        listeners.Add(listener);
    }

    public void Unsubscribe(string eventType, IEventListener listener) {
        if (listenersDict.TryGetValue(eventType, out List<IEventListener>? listeners)) {
            listeners.Remove(listener);
        }
    }

    public void Notify(string eventType, string data) {
        if (listenersDict.TryGetValue(eventType, out List<IEventListener>? listeners)) {
            foreach (var listener in listeners) {
                listener.Update(data);
            }
        }
    }
}