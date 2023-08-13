namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SteamVR Extensions Function Library</summary>
[CppInclude("SteamVRFunctionLibrary.h")]
public partial class USteamVRFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns an array of the currently tracked device IDs</summary>
	public static void GetValidTrackedDeviceIds(ESteamVRTrackedDeviceType DeviceType,TArray<int> OutTrackedDeviceIds) {}
	///<summary>Gets the orientation and position (in device space) of the device with the specified ID</summary>
	public static bool GetTrackedDevicePositionAndOrientation(int DeviceId,FVector OutPosition,FRotator OutOrientation) { return default; }
	///<summary>Given a controller index and a hand, returns the position and orientation of the controller</summary>
	public static bool GetHandPositionAndOrientation(int ControllerIndex,EControllerHand Hand,FVector OutPosition,FRotator OutOrientation) { return default; }
}
