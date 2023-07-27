#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SteamVRFunctionLibrary.h")]
///<summary>SteamVR Extensions Function Library</summary>
public partial class USteamVRFunctionLibrary : UBlueprintFunctionLibrary {
// SteamVRFunctionLibrary
	public static void GetValidTrackedDeviceIds(ESteamVRTrackedDeviceType DeviceType,TArray<int> OutTrackedDeviceIds) {}
	public static bool GetTrackedDevicePositionAndOrientation(int DeviceId,FVector OutPosition,FRotator OutOrientation) { return default; }
	public static bool GetHandPositionAndOrientation(int ControllerIndex,EControllerHand Hand,FVector OutPosition,FRotator OutOrientation) { return default; }
}
