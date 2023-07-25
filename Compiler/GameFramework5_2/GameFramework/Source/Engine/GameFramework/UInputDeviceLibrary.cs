#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputDeviceLibrary.h")]
///<summary>A static BP library that exposes Input Device data to blueprints</summary>
public partial class UInputDeviceLibrary : UBlueprintFunctionLibrary {
// InputDeviceLibrary
	public UObject GetPlayerControllerFromPlatformUser(FPlatformUserId UserId) { return default; }
	public UObject GetPlayerControllerFromInputDevice(FInputDeviceId DeviceId) { return default; }
	public bool IsDevicePropertyHandleValid(FInputDevicePropertyHandle InHandle) { return default; }
	public int GetAllInputDevicesForUser(FPlatformUserId UserId,TArray<FInputDeviceId> OutInputDevices) { return default; }
	public int GetAllInputDevices(TArray<FInputDeviceId> OutInputDevices) { return default; }
	public int GetAllConnectedInputDevices(TArray<FInputDeviceId> OutInputDevices) { return default; }
	public int GetAllActiveUsers(TArray<FPlatformUserId> OutUsers) { return default; }
	public FPlatformUserId GetUserForUnpairedInputDevices() { return default; }
	public FPlatformUserId GetPrimaryPlatformUser() { return default; }
	public bool IsUnpairedUserId(FPlatformUserId PlatformId) { return default; }
	public bool IsInputDeviceMappedToUnpairedUser(FInputDeviceId InputDevice) { return default; }
	public FInputDeviceId GetDefaultInputDevice() { return default; }
	public FPlatformUserId GetUserForInputDevice(FInputDeviceId DeviceId) { return default; }
	public FInputDeviceId GetPrimaryInputDeviceForUser(FPlatformUserId UserId) { return default; }
	public EInputDeviceConnectionState GetInputDeviceConnectionState(FInputDeviceId DeviceId) { return default; }
	public bool IsValidInputDevice(FInputDeviceId DeviceId) { return default; }
	public bool IsValidPlatformId(FPlatformUserId UserId) { return default; }
	public FPlatformUserId PlatformUserId_None() { return default; }
	public FInputDeviceId InputDeviceId_None() { return default; }
	public bool EqualEqual_PlatformUserId(FPlatformUserId A,FPlatformUserId B) { return default; }
	public bool NotEqual_PlatformUserId(FPlatformUserId A,FPlatformUserId B) { return default; }
	public bool EqualEqual_InputDeviceId(FInputDeviceId A,FInputDeviceId B) { return default; }
	public bool NotEqual_InputDeviceId(FInputDeviceId A,FInputDeviceId B) { return default; }
}
