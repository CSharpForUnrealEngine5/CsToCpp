#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputDeviceLibrary.h")]
///<summary>A static BP library that exposes Input Device data to blueprints</summary>
public partial class UInputDeviceLibrary : UBlueprintFunctionLibrary {
// InputDeviceLibrary
	public static APlayerController GetPlayerControllerFromPlatformUser(FPlatformUserId UserId) { return default; }
	public static APlayerController GetPlayerControllerFromInputDevice(FInputDeviceId DeviceId) { return default; }
	public static bool IsDevicePropertyHandleValid(FInputDevicePropertyHandle InHandle) { return default; }
	public static int GetAllInputDevicesForUser(FPlatformUserId UserId,TArray<FInputDeviceId> OutInputDevices) { return default; }
	public static int GetAllInputDevices(TArray<FInputDeviceId> OutInputDevices) { return default; }
	public static int GetAllConnectedInputDevices(TArray<FInputDeviceId> OutInputDevices) { return default; }
	public static int GetAllActiveUsers(TArray<FPlatformUserId> OutUsers) { return default; }
	public static FPlatformUserId GetUserForUnpairedInputDevices() { return default; }
	public static FPlatformUserId GetPrimaryPlatformUser() { return default; }
	public static bool IsUnpairedUserId(FPlatformUserId PlatformId) { return default; }
	public static bool IsInputDeviceMappedToUnpairedUser(FInputDeviceId InputDevice) { return default; }
	public static FInputDeviceId GetDefaultInputDevice() { return default; }
	public static FPlatformUserId GetUserForInputDevice(FInputDeviceId DeviceId) { return default; }
	public static FInputDeviceId GetPrimaryInputDeviceForUser(FPlatformUserId UserId) { return default; }
	public static EInputDeviceConnectionState GetInputDeviceConnectionState(FInputDeviceId DeviceId) { return default; }
	public static bool IsValidInputDevice(FInputDeviceId DeviceId) { return default; }
	public static bool IsValidPlatformId(FPlatformUserId UserId) { return default; }
	public static FPlatformUserId PlatformUserId_None() { return default; }
	public static FInputDeviceId InputDeviceId_None() { return default; }
	public static bool EqualEqual_PlatformUserId(FPlatformUserId A,FPlatformUserId B) { return default; }
	public static bool NotEqual_PlatformUserId(FPlatformUserId A,FPlatformUserId B) { return default; }
	public static bool EqualEqual_InputDeviceId(FInputDeviceId A,FInputDeviceId B) { return default; }
	public static bool NotEqual_InputDeviceId(FInputDeviceId A,FInputDeviceId B) { return default; }
}
