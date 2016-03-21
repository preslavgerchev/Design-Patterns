namespace Adapter_Pattern
{
    public class AnalogToDigitalAdapter : IDigitalSignalTransmitter
    {
        private IAnalogSignalTransmitter analogSignal;

        public AnalogToDigitalAdapter(IAnalogSignalTransmitter analogSignal)
        {
            this.analogSignal = analogSignal;
        }

        public string TransmitDigitalData(string information)
        {
            return analogSignal.TransmitAnalogData(information);
        }
    }
}