using RemoteDevices.Devices;

namespace RemoteDevices.Remotes;

// Extended Abstraction: AdvancedRemote
public class AdvancedRemote : Remote
{
    public AdvancedRemote(IDevice device) : base(device) 
    {
    
    }

    public void Mute()
    {
        _device.SetVolume(0);
    }
}
