namespace ECS.Legacy_Refactored;

public interface IHeater
{
    void TurnOn();
    void TurnOff();
    bool RunSelfTest();
}