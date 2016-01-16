# Button LED Example for Netduino

Controlling an LED with a switch using the original Netduino. Repository created for educational purposes.

## What You'll Need

Software:

* [Netduino SDK](http://www.netduino.com/downloads/)
* [Visual C# Express 2010](https://www.visualstudio.com/)
* [Micro Framework](http://www.netduino.com/downloads/)

Parts:

* [Netduino 1](http://www.netduino.com/netduino/specs.htm)
* Two 220Ω Resistors
* One LED
* One Standard Breadboard
* Seven Wires
* One Switch

## Breadboard

![See Breadboard.svg](http://i.imgur.com/hFH7WhI.jpg?1)

## Code

```c#
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
```
