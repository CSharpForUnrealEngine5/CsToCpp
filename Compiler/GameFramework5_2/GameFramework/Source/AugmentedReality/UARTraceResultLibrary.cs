namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARBlueprintLibrary.h")]
public partial class UARTraceResultLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>@return  the distance from the camera to the traced location in Unreal Units.</summary>
	public static float GetDistanceFromCamera(FARTraceResult TraceResult) { return default; }
	///<summary>@return The transform of the trace result in tracking space (after it is modified by the \c AlignmentTransform).</summary>
	public static FTransform GetLocalToTrackingTransform(FARTraceResult TraceResult) { return default; }
	///<summary>@return Get the transform of the trace result in Unreal World Space.</summary>
	public static FTransform GetLocalToWorldTransform(FARTraceResult TraceResult) { return default; }
	///<summary>@return Get the transform of the trace result in the AR system&#39;s local space.</summary>
	public static FTransform GetLocalTransform(FARTraceResult TraceResult) { return default; }
	///<summary>@return Get the real-world object (as observed by the Augmented Reality system) that was intersected by the line trace.</summary>
	public static UARTrackedGeometry GetTrackedGeometry(FARTraceResult TraceResult) { return default; }
	///<summary>@return  Get the type of the tracked object (if any) that effected this trace result.</summary>
	public static EARLineTraceChannels GetTraceChannel(FARTraceResult TraceResult) { return default; }
}
