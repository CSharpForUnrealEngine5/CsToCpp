#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARPin.h")]
public partial class UARPin : UObject {
// ARPin
	public  FTransform GetLocalToTrackingTransform() { return default; }
	public  FTransform GetLocalToWorldTransform() { return default; }
	public  EARTrackingState GetTrackingState() { return default; }
	public  UARTrackedGeometry GetTrackedGeometry() { return default; }
	public  USceneComponent GetPinnedComponent() { return default; }
	public  void DebugDraw(UWorld World,FLinearColor Color,float Scale,float PersistForSeconds) {}
	public  string GetDebugName() { return default; }
	public UARTrackedGeometry TrackedGeometry;
	public USceneComponent PinnedComponent;
	public FTransform LocalToTrackingTransform;
	public FTransform LocalToAlignedTrackingTransform;
	public EARTrackingState TrackingState;
	public FOnARTrackingStateChanged OnARTrackingStateChanged;
	public FOnARTransformUpdated OnARTransformUpdated;
}
