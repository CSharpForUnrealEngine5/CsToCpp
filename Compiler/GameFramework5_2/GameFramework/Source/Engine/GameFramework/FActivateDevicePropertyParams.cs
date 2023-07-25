#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputDeviceSubsystem.h")]
///<summary>Parameters for the UInputDeviceSubsystem::ActivateDeviceProperty function</summary>
public partial struct FActivateDevicePropertyParams {
// ActivateDevicePropertyParams
	public FPlatformUserId UserId;
	public FInputDeviceId DeviceId;
	public bool bLooping;
	public bool bIgnoreTimeDilation;
	public bool bPlayWhilePaused;
}
