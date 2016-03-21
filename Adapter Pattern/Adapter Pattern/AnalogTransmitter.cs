namespace Adapter_Pattern
{
    public class AnalogTransmitter : IAnalogSignalTransmitter
    {
        public string TransmitAnalogData(string information)
        {
            return "Analogously processed the following data: " + information;
        }
    }
}