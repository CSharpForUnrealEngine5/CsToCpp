namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionTrackedDeviceFunctionLibrary.h")]
public partial class UMotionTrackedDeviceFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns true if it is necessary for the game to manage how many motion tracked devices it is asking to be tracked simultaneously.</summary>
	public static bool IsMotionTrackedDeviceCountManagementNecessary() { return default; }
	///<summary>Set whether motion tracked controllers activate on creation by default, or do not and must be explicitly activated.</summary>
	public static void SetIsControllerMotionTrackingEnabledByDefault(bool Enable) {}
	///<summary>Get the maximum number of controllers that can be tracked.</summary>
	public static int GetMaximumMotionTrackedControllerCount() { return default; }
	///<summary>Get the number of controllers for which tracking is enabled.</summary>
	public static int GetMotionTrackingEnabledControllerCount() { return default; }
	///<summary>Returns true if tracking is enabled for the specified device.</summary>
	public static bool IsMotionTrackingEnabledForDevice(int PlayerIndex,EControllerHand Hand) { return default; }
	///<summary>Returns true if tracking is enabled for the specified device.</summary>
	public static bool IsMotionTrackingEnabledForSource(int PlayerIndex,FName SourceName) { return default; }
	///<summary>Returns true if tracking is enabled for the specified device.</summary>
	public static bool IsMotionTrackingEnabledForComponent(UMotionControllerComponent MotionControllerComponent) { return default; }
	///<summary>Enable tracking of the specified controller, by player index and tracked device type.</summary>
	public static bool EnableMotionTrackingOfDevice(int PlayerIndex,EControllerHand Hand) { return default; }
	///<summary>Enable tracking of the specified controller, by player index and tracked device type.</summary>
	public static bool EnableMotionTrackingOfSource(int PlayerIndex,FName SourceName) { return default; }
	///<summary>Enable tracking of the specified controller, by player index and tracked device type.</summary>
	public static bool EnableMotionTrackingForComponent(UMotionControllerComponent MotionControllerComponent) { return default; }
	///<summary>Disable tracking of the specified controller, by player index and tracked device type.</summary>
	public static void DisableMotionTrackingOfDevice(int PlayerIndex,EControllerHand Hand) {}
	///<summary>Disable tracking of the specified controller, by player index and tracked device type.</summary>
	public static void DisableMotionTrackingOfSource(int PlayerIndex,FName SourceName) {}
	///<summary>Disable tracking of the specified controller, by player index and tracked device type.</summary>
	public static void DisableMotionTrackingForComponent(UMotionControllerComponent MotionControllerComponent) {}
	///<summary>Disable tracking for all controllers.</summary>
	public static void DisableMotionTrackingOfAllControllers() {}
	///<summary>Disable tracking for all controllers associated with the specified player.</summary>
	public static void DisableMotionTrackingOfControllersForPlayer(int PlayerIndex) {}
	///<summary>Returns a list of all available motion sources (FNames associated with</summary>
	public static TArray<FName> EnumerateMotionSources() { return default; }
	///<summary>Returns the system name used to distinguish the current tracking system.</summary>
	public static FName GetActiveTrackingSystemName() { return default; }
	///<summary>Queries the specified source&#39;s tracking status and returns true if it has tracking.</summary>
	public static bool IsMotionSourceTracking(int PlayerIndex,FName SourceName) { return default; }
}
