namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A static BP library that exposes Input Device data to blueprints</summary>
[CppInclude("GameFramework/InputDeviceLibrary.h")]
public partial class UInputDeviceLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get the player controller who has the given Platform User ID.</summary>
	public static APlayerController GetPlayerControllerFromPlatformUser(FPlatformUserId UserId) { return default; }
	///<summary>Get the player controller who owns the given input device id</summary>
	public static APlayerController GetPlayerControllerFromInputDevice(FInputDeviceId DeviceId) { return default; }
	///<summary>Returns true if the given handle is valid</summary>
	public static bool IsDevicePropertyHandleValid(FInputDevicePropertyHandle InHandle) { return default; }
	///<summary>Populates the OutInputDevices array with any InputDeviceID&#39;s that are mapped to the given platform user</summary>
	public static int GetAllInputDevicesForUser(FPlatformUserId UserId,TArray<FInputDeviceId> OutInputDevices) { return default; }
	///<summary>Get all mapped input devices on this platform regardless of their connection state.</summary>
	public static int GetAllInputDevices(TArray<FInputDeviceId> OutInputDevices) { return default; }
	///<summary>Gather all currently connected input devices</summary>
	public static int GetAllConnectedInputDevices(TArray<FInputDeviceId> OutInputDevices) { return default; }
	///<summary>Get all currently active platform ids, anyone who has a mapped input device</summary>
	public static int GetAllActiveUsers(TArray<FPlatformUserId> OutUsers) { return default; }
	///<summary>Returns the platform user id that is being used for unmapped input devices.</summary>
	public static FPlatformUserId GetUserForUnpairedInputDevices() { return default; }
	///<summary>Returns the &#39;Primary&#39; Platform user for this platform.</summary>
	public static FPlatformUserId GetPrimaryPlatformUser() { return default; }
	///<summary>Returns true if the given Platform User Id is the user for unpaired input devices on this platform.</summary>
	public static bool IsUnpairedUserId(FPlatformUserId PlatformId) { return default; }
	///<summary>Returns true if the given input device is mapped to the unpaired platform user id.</summary>
	public static bool IsInputDeviceMappedToUnpairedUser(FInputDeviceId InputDevice) { return default; }
	///<summary>Returns the default device id used for things like keyboard/mouse input</summary>
	public static FInputDeviceId GetDefaultInputDevice() { return default; }
	///<summary>Returns the platform user attached to this input device, or PLATFORMUSERID_NONE if invalid</summary>
	public static FPlatformUserId GetUserForInputDevice(FInputDeviceId DeviceId) { return default; }
	///<summary>Returns the primary input device used by a specific player, or INPUTDEVICEID_NONE if invalid</summary>
	public static FInputDeviceId GetPrimaryInputDeviceForUser(FPlatformUserId UserId) { return default; }
	///<summary>Gets the connection state of the given input device.</summary>
	public static EInputDeviceConnectionState GetInputDeviceConnectionState(FInputDeviceId DeviceId) { return default; }
	///<summary>Check if the given input device is valid</summary>
	public static bool IsValidInputDevice(FInputDeviceId DeviceId) { return default; }
	///<summary>Check if the given platform ID is valid</summary>
	public static bool IsValidPlatformId(FPlatformUserId UserId) { return default; }
	///<summary>Static invalid platform user</summary>
	public static FPlatformUserId PlatformUserId_None() { return default; }
	///<summary>Static invalid input device</summary>
	public static FInputDeviceId InputDeviceId_None() { return default; }
	///<summary>Returns true if PlatformUserId A is equal to PlatformUserId B (A == B)</summary>
	public static bool EqualEqual_PlatformUserId(FPlatformUserId A,FPlatformUserId B) { return default; }
	///<summary>Returns true if PlatformUserId A is not equal to PlatformUserId B (A != B)</summary>
	public static bool NotEqual_PlatformUserId(FPlatformUserId A,FPlatformUserId B) { return default; }
	///<summary>Returns true if InputDeviceId A is equal to InputDeviceId B (A == B)</summary>
	public static bool EqualEqual_InputDeviceId(FInputDeviceId A,FInputDeviceId B) { return default; }
	///<summary>Returns true if InputDeviceId A is not equal to InputDeviceId B (A != B)</summary>
	public static bool NotEqual_InputDeviceId(FInputDeviceId A,FInputDeviceId B) { return default; }
}
