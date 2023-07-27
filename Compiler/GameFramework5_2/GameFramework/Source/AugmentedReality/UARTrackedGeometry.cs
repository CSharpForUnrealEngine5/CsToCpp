#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARTrackedGeometry : UObject {
// ARTrackedGeometry
	public  FTransform GetLocalToWorldTransform() { return default; }
	public  FTransform GetLocalToTrackingTransform() { return default; }
	public  EARTrackingState GetTrackingState() { return default; }
	public  bool IsTracked() { return default; }
	public  string GetDebugName() { return default; }
	public  string GetName() { return default; }
	public  int GetLastUpdateFrameNumber() { return default; }
	public  float GetLastUpdateTimestamp() { return default; }
	public  UMRMeshComponent GetUnderlyingMesh() { return default; }
	public FGuid UniqueId;
	public  EARObjectClassification GetObjectClassification() { return default; }
	public  bool HasSpatialMeshUsageFlag(EARSpatialMeshUsageFlags InFlag) { return default; }
	public FTransform LocalToTrackingTransform;
	public FTransform LocalToAlignedTrackingTransform;
	public EARTrackingState TrackingState;
	public UMRMeshComponent UnderlyingMesh;
	public EARObjectClassification ObjectClassification;
	public EARSpatialMeshUsageFlags SpatialMeshUsageFlags;
	public int LastUpdateFrameNumber;
	public string DebugName;
}
