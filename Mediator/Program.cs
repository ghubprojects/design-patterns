using Mediator;

var room = new Chatroom();

var im = new User(room, "IronMan");
var ca = new User(room, "Captain America");
var hu = new User(room, "Hulk");

var noti = new Notification(room, "chatroom");

Console.WriteLine("{0,-20} | {1,-20} | {2}", "Chat screen", "Sender", "Message");
Console.WriteLine(new string('-', 70));

room.Join(noti, im);
room.Join(noti, ca);
room.Join(noti, hu);

ca.Broadcast("Hello Avengers !!! Ready for END GAME");
im.Broadcast("Aye Aye Captain !!!");
hu.Broadcast("Aye Aye Captain !!!");

ca.Send(hu, "Smash everyone !!!");
ca.Send(im, "Tony close the gate!!!");