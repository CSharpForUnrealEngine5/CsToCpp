#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionTrackedDeviceFunctionLibrary.h")]
public partial class UMotionTrackedDeviceFunctionLibrary : UBlueprintFunctionLibrary {
// MotionTrackedDeviceFunctionLibrary
	public static bool IsMotionTrackedDeviceCountManagementNecessary() { return default; }
	public static void SetIsControllerMotionTrackingEnabledByDefault(bool Enable) {}
	public static int GetMaximumMotionTrackedControllerCount() { return default; }
	public static int GetMotionTrackingEnabledControllerCount() { return default; }
	public static bool IsMotionTrackingEnabledForDevice(int PlayerIndex,EControllerHand Hand) { return default; }
	public static bool IsMotionTrackingEnabledForSource(int PlayerIndex,string SourceName) { return default; }
	public static bool IsMotionTrackingEnabledForComponent(UMotionControllerComponent MotionControllerComponent) { return default; }
	public static bool EnableMotionTrackingOfDevice(int PlayerIndex,EControllerHand Hand) { return default; }
	public static bool EnableMotionTrackingOfSource(int PlayerIndex,string SourceName) { return default; }
	public static bool EnableMotionTrackingForComponent(UMotionControllerComponent MotionControllerComponent) { return default; }
	public static void DisableMotionTrackingOfDevice(int PlayerIndex,EControllerHand Hand) {}
	public static void DisableMotionTrackingOfSource(int PlayerIndex,string SourceName) {}
	public static void DisableMotionTrackingForComponent(UMotionControllerComponent MotionControllerComponent) {}
	public static void DisableMotionTrackingOfAllControllers() {}
	public static void DisableMotionTrackingOfControllersForPlayer(int PlayerIndex) {}
	public static TArray<string> EnumerateMotionSources() { return default; }
	public static string GetActiveTrackingSystemName() { return default; }
	public static bool IsMotionSourceTracking(int PlayerIndex,string SourceName) { return default; }
}
