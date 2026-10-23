using nanoFramework.Hardware.Esp32;

namespace SmartFanController;

/// <summary>
/// Pin assignments for the Radiator Fan USB-PD Controller v1.2.
/// </summary>
public static class HardwareConfiguration
{
    public const int StatusLed = 1;

    public const int UsbVoltageAdc = 2;
    public const int Ntc1Adc = 4;
    public const int Ntc2Adc = 5;
    public const int InternalNtcAdc = 6;

    public const int Ntc0Power = 13;
    public const int I2c1Data = 9;
    public const int I2c1Clock = 10;
    public const int I2c2Data = 18;
    public const int I2c2Clock = 21;
    public const int Ntc2Power = 33;

    public const int FanControl = 38;
    public const int PdConfiguration3 = 40;
    public const int PdConfiguration2 = 41;
    public const int PdConfiguration1 = 42;
    public const int Ntc1Power = 47;

    /// <summary>
    /// Routes the controller's ADC and I2C signals to their peripheral functions.
    /// GPIO direction and mode are configured when their GPIO devices are created.
    /// Call once before creating ADC or I2C devices.
    /// </summary>
    public static void ConfigurePins()
    {
        Configuration.SetPinFunction(UsbVoltageAdc, DeviceFunction.ADC1_CH1);
        Configuration.SetPinFunction(Ntc1Adc, DeviceFunction.ADC1_CH3);
        Configuration.SetPinFunction(Ntc2Adc, DeviceFunction.ADC1_CH4);
        Configuration.SetPinFunction(InternalNtcAdc, DeviceFunction.ADC1_CH5);

        Configuration.SetPinFunction(I2c1Data, DeviceFunction.I2C1_DATA);
        Configuration.SetPinFunction(I2c1Clock, DeviceFunction.I2C1_CLOCK);
        Configuration.SetPinFunction(I2c2Data, DeviceFunction.I2C2_DATA);
        Configuration.SetPinFunction(I2c2Clock, DeviceFunction.I2C2_CLOCK);
    }
}
