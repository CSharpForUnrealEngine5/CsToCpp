#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionTrackedDeviceFunctionLibrary.h")]
public partial class UMotionTrackedDeviceFunctionLibrary : UBlueprintFunctionLibrary {
// MotionTrackedDeviceFunctionLibrary
	public bool IsMotionTrackedDeviceCountManagementNecessary() { return default; }
	public void SetIsControllerMotionTrackingEnabledByDefault(bool Enable) {}
	public int GetMaximumMotionTrackedControllerCount() { return default; }
	public int GetMotionTrackingEnabledControllerCount() { return default; }
	public bool IsMotionTrackingEnabledForDevice(int PlayerIndex,EControllerHand Hand) { return default; }
	public bool IsMotionTrackingEnabledForSource(int PlayerIndex,string SourceName) { return default; }
	public bool IsMotionTrackingEnabledForComponent(UObject MotionControllerComponent) { return default; }
	public bool EnableMotionTrackingOfDevice(int PlayerIndex,EControllerHand Hand) { return default; }
	public bool EnableMotionTrackingOfSource(int PlayerIndex,string SourceName) { return default; }
	public bool EnableMotionTrackingForComponent(UObject MotionControllerComponent) { return default; }
	public void DisableMotionTrackingOfDevice(int PlayerIndex,EControllerHand Hand) {}
	public void DisableMotionTrackingOfSource(int PlayerIndex,string SourceName) {}
	public void DisableMotionTrackingForComponent(UObject MotionControllerComponent) {}
	public void DisableMotionTrackingOfAllControllers() {}
	public void DisableMotionTrackingOfControllersForPlayer(int PlayerIndex) {}
	public TArray<string> EnumerateMotionSources() { return default; }
	public string GetActiveTrackingSystemName() { return default; }
	public bool IsMotionSourceTracking(int PlayerIndex,string SourceName) { return default; }
}
