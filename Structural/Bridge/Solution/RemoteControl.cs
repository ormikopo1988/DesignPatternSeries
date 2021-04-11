namespace Bridge.Solution
{
    public class RemoteControl
    {
        protected readonly IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TurnOff()
        {
            device.TurnOff();
        }

        public void TurnOn()
        {
            device.TurnOn();
        }
    }
}
