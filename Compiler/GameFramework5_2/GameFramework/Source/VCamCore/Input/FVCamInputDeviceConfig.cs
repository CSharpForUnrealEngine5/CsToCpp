#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Input/VCamInputDeviceConfig.h")]
///<summary>Defines the input devices a UVCamComponent will accept input from.</summary>
public partial struct FVCamInputDeviceConfig {
// VCamInputDeviceConfig
	public bool bAllowAllInputDevices;
	public TArray<FVCamInputDeviceID> AllowedInputDeviceIds;
	public EVCamInputMode KeyboardInputMode;
	public EVCamInputMode MouseInputMode;
	public EVCamGamepadInputMode GamepadInputMode;
	public EVCamInputLoggingMode LoggingMode;
}
