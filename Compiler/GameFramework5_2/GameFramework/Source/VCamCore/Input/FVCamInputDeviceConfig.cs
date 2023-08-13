namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines the input devices a UVCamComponent will accept input from.</summary>
[CppInclude("Input/VCamInputDeviceConfig.h")]
public partial struct FVCamInputDeviceConfig {
	public bool bAllowAllInputDevices;
	public TArray<FVCamInputDeviceID> AllowedInputDeviceIds;
	public EVCamInputMode KeyboardInputMode;
	public EVCamInputMode MouseInputMode;
	public EVCamGamepadInputMode GamepadInputMode;
	public EVCamInputLoggingMode LoggingMode;
}
