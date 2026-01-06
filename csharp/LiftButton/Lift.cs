namespace LiftButton;

public class Lift
{
    private string _lights = "OFF";


    public string Doors()
    {
        return "CLOSED";
    }

    public void PressButton()
    {
        _lights = "ON";
    }

    public string Lights()
    {
        return _lights;
    }
}