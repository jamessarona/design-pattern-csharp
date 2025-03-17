using RemoteDevices.Devices;
using RemoteDevices.Remotes;

IDevice tv = new TV();
Remote remote = new Remote(tv);

Console.WriteLine(tv);
remote.TogglePower();
remote.VolumeUp();
remote.ChannelUp();
Console.WriteLine(tv);

IDevice radio = new Radio();
AdvancedRemote advRemote = new AdvancedRemote(radio);

Console.WriteLine(radio);
advRemote.TogglePower();
advRemote.Mute();
advRemote.ChannelDown();
Console.WriteLine(radio);