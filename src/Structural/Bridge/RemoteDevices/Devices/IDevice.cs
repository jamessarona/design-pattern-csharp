namespace RemoteDevices.Devices;

// Device Interface (Implementation)
public interface IDevice
{
    bool IsEnabled();
    void Enable();
    void Disable();
    int GetVolume();
    void SetVolume(int percentage);
    int GetChannel();
    void SetChannel(int channel);
}