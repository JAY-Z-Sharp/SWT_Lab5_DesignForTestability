namespace ECS.Legacy_Refactored;

public interface ITempSensor
{
    int GetTemp();
    bool RunSelfTest();
}