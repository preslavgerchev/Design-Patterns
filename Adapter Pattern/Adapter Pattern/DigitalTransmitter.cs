namespace Adapter_Pattern
{
    public class DigitalTransmitter : IDigitalSignalTransmitter
    {
        public string TransmitDigitalData(string information)
        {
            return "digital: " + information;
        }
    }
}