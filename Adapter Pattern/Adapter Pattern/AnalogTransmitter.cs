namespace Adapter_Pattern
{
    public class AnalogTransmitter : IAnalogSignalTransmitter
    {
        public string TransmitAnalogData(string information)
        {
            return "analog: " + information;
        }
    }
}