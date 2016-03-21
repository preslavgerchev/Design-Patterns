namespace Adapter_Pattern
{
    public class AnalogToDigitalAdapter : IDigitalSignalTransmitter
    {
        private IAnalogSignalTransmitter analogTransmitter;

        public AnalogToDigitalAdapter(IAnalogSignalTransmitter analogSignal)
        {
            this.analogTransmitter = analogSignal;
        }

        public string TransmitDigitalData(string information)
        {
            return ProcessAnalogData(analogTransmitter.TransmitAnalogData(information));
        }

        private string ProcessAnalogData(string information)
        {
            return string.Format("The analog data :\"{0}\" has been processsed and is now digitally readable", information);
        }
    }
}