using RemoteDevices.Devices;

namespace RemoteDevices.Remotes;

// Abstraction: Remote
public class Remote
{
    protected IDevice _device;

    public Remote(IDevice device)
    {
        _device = device;
    }

    public void TogglePower()
    {
        if (_device.IsEnabled())
            _device.Disable();
        else
            _device.Enable();
    }

    public void VolumeDown()
    {
        int oldVolume = _device.GetVolume();

        if (oldVolume > 0)
            _device.SetVolume(--oldVolume);
    }

    public void VolumeUp()
    {
        int oldVolume = _device.GetVolume();

        if (oldVolume < 100)
            _device.SetVolume(++oldVolume);
    }

    public void ChannelDown()
    {
        int oldChannel = _device.GetChannel();

        if (oldChannel > 1)
            _device.SetChannel(--oldChannel);
    }

    public void ChannelUp()
    {
        int oldChannel = _device.GetChannel();

        if (oldChannel < 100)
            _device.SetChannel(++oldChannel);
    }
}