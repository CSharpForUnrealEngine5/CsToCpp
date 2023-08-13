namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class that represents a single Input Device Property. An Input Device Property</summary>
[CppInclude("GameFramework/InputDeviceProperties.h")]
public partial class UInputDeviceProperty : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Evaluate this device property for a given duration.</summary>
	public void EvaluateDeviceProperty(FPlatformUserId PlatformUser,FInputDeviceId DeviceId,float DeltaTime,float Duration) {}
	///<summary>Reset the current device property. Provides an opportunity to reset device state after evaluation is complete.</summary>
	public void ResetDeviceProperty(FPlatformUserId PlatformUser,FInputDeviceId DeviceId) {}
	///<summary>Apply the device property from GetInternalDeviceProperty to the given platform user.</summary>
	public virtual void ApplyDeviceProperty(FPlatformUserId UserId,FInputDeviceId DeviceId) {}
	///<summary>The duration that this device property should last. Override this if your property has any dynamic curves</summary>
	public float PropertyDuration;
}
