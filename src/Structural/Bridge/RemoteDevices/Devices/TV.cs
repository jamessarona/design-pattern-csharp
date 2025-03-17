using System.Threading.Channels;

namespace RemoteDevices.Devices;

// Concrete Implementation: TV
public class TV : IDevice
{
    private bool _isEnabled = false;
    private int _volume = 50;
    private int _channel = 1;

    public bool IsEnabled()
    {
        return _isEnabled;
    }

    public void Enable()
    {
        _isEnabled = true;
    }

    public void Disable()
    {
        _isEnabled = false;
    }

    public int GetVolume()
    {
        return _volume;
    }

    public void SetVolume(int percentage)
    {
        _volume = percentage;
    }

    public int GetChannel()
    {
        return _channel;
    }

    public void SetChannel(int channel)
    {
        _channel = channel;
    }

    public override string ToString()
    {
        return $"TV - Power: {_isEnabled}, Volume: {_volume}, Channel: {_channel}";
    }
}