#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputDeviceProperties.h")]
///<summary>Base class that represents a single Input Device Property. An Input Device Property</summary>
public partial class UInputDeviceProperty : UObject {
// InputDeviceProperty
	public void EvaluateDeviceProperty(FPlatformUserId PlatformUser,FInputDeviceId DeviceId,float DeltaTime,float Duration) {}
	public void ResetDeviceProperty(FPlatformUserId PlatformUser,FInputDeviceId DeviceId) {}
	public void ApplyDeviceProperty(FPlatformUserId UserId,FInputDeviceId DeviceId) {}
	public float PropertyDuration;
}
