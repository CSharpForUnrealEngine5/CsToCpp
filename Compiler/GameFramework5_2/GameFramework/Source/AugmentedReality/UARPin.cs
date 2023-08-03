#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARPin.h")]
public partial class UARPin : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Maps from a Pin&#39;s Local Space to the Tracking Space.</summary>
	public  FTransform GetLocalToTrackingTransform() { return default; }
	///<summary>Convenience function. Same as LocalToTrackingTransform, but</summary>
	public  FTransform GetLocalToWorldTransform() { return default; }
	///<summary>Return the current tracking state of this Pin.</summary>
	public  EARTrackingState GetTrackingState() { return default; }
	///<summary>The TrackedGeometry (if any) that this this pin is being &quot;stuck&quot; into.</summary>
	public  UARTrackedGeometry GetTrackedGeometry() { return default; }
	///<summary>@return the PinnedComponent that this UARPin is pinning to the TrackedGeometry</summary>
	public  USceneComponent GetPinnedComponent() { return default; }
	///<summary>DebugDraw</summary>
	public  void DebugDraw(UWorld World,FLinearColor Color,float Scale,float PersistForSeconds) {}
	///<summary>GetDebugName</summary>
	public  string GetDebugName() { return default; }
	///<summary>TrackedGeometry</summary>
	public UARTrackedGeometry TrackedGeometry;
	///<summary>PinnedComponent</summary>
	public USceneComponent PinnedComponent;
	///<summary>LocalToTrackingTransform</summary>
	public FTransform LocalToTrackingTransform;
	///<summary>LocalToAlignedTrackingTransform</summary>
	public FTransform LocalToAlignedTrackingTransform;
	///<summary>TrackingState</summary>
	public EARTrackingState TrackingState;
	///<summary>OnARTrackingStateChanged</summary>
	public FOnARTrackingStateChanged OnARTrackingStateChanged;
	///<summary>OnARTransformUpdated</summary>
	public FOnARTransformUpdated OnARTransformUpdated;
}
