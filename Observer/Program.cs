using Observer;

var editor = new Editor();

var logger = new LoggingListener("/path/to/log.txt", "Someone has opened the file: {0}");
editor.Events.Subscribe("open", logger);

var emailAlerts = new EmailAlertsListener("admin@example.com", "Someone has changed the file: {0}");
editor.Events.Subscribe("save", emailAlerts);

editor.OpenFile("test.txt");
editor.SaveFile();

editor.Events.Unsubscribe("save", emailAlerts);
editor.OpenFile("test.txt");
editor.SaveFile();