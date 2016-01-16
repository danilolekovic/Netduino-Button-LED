using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace ButtonLED
{
    public class Program
    {
        public static void Main()
        {
            var led = new OutputPort(Pins.GPIO_PIN_D13, false);

            var button = new InputPort(Pins.GPIO_PIN_D2, false, Port.ResistorMode.Disabled);
            while (true)
            {
                if (!button.Read())
                {
                    led.Write(!led.Read());
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
