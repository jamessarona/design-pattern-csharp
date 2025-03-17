namespace RemoteDevices.Devices;

class Radio : IDevice
{
    private bool _isEnabled = false;
    private int _volume = 30;
    private int _channel = 90;

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
        return $"Radio - Power: {_isEnabled}, Volume: {_volume}, Channel: {_channel}";
    }
}
