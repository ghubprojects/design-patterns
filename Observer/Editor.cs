namespace Observer;

public class Editor {
    public EventManager Events { get; private set; }
    private string file = string.Empty;

    public Editor() {
        Events = new EventManager();
    }

    public void OpenFile(string path) {
        file = path;
        Events.Notify("open", file);
    }

    public void SaveFile() {
        Events.Notify("save", file);
    }
}