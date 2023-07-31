#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters for the UInputDeviceSubsystem::ActivateDeviceProperty function</summary>
[CppInclude("GameFramework/InputDeviceSubsystem.h")]
public partial struct FActivateDevicePropertyParams {
	public FPlatformUserId UserId;
	public FInputDeviceId DeviceId;
	public bool bLooping;
	public bool bIgnoreTimeDilation;
	public bool bPlayWhilePaused;
}
