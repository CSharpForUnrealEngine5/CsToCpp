#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARTrackedGeometry : UObject {
	///<summary>GetLocalToWorldTransform</summary>
	public  FTransform GetLocalToWorldTransform() { return default; }
	///<summary>GetLocalToTrackingTransform</summary>
	public  FTransform GetLocalToTrackingTransform() { return default; }
	///<summary>GetTrackingState</summary>
	public  EARTrackingState GetTrackingState() { return default; }
	///<summary>IsTracked</summary>
	public  bool IsTracked() { return default; }
	///<summary>GetDebugName</summary>
	public  string GetDebugName() { return default; }
	///<summary>GetName</summary>
	public  string GetName() { return default; }
	///<summary>GetLastUpdateFrameNumber</summary>
	public  int GetLastUpdateFrameNumber() { return default; }
	///<summary>GetLastUpdateTimestamp</summary>
	public  float GetLastUpdateTimestamp() { return default; }
	///<summary>GetUnderlyingMesh</summary>
	public  UMRMeshComponent GetUnderlyingMesh() { return default; }
	///<summary>UniqueId</summary>
	public FGuid UniqueId;
	///<summary>GetObjectClassification</summary>
	public  EARObjectClassification GetObjectClassification() { return default; }
	///<summary>HasSpatialMeshUsageFlag</summary>
	public  bool HasSpatialMeshUsageFlag(EARSpatialMeshUsageFlags InFlag) { return default; }
	///<summary>LocalToTrackingTransform</summary>
	public FTransform LocalToTrackingTransform;
	///<summary>LocalToAlignedTrackingTransform</summary>
	public FTransform LocalToAlignedTrackingTransform;
	///<summary>TrackingState</summary>
	public EARTrackingState TrackingState;
	///<summary>For AR systems that support arbitrary mesh geometry associated with a tracked point</summary>
	public UMRMeshComponent UnderlyingMesh;
	///<summary>What the scene understanding system thinks this object is</summary>
	public EARObjectClassification ObjectClassification;
	///<summary>How the scene understanding system thinks this mesh should be displayed</summary>
	public EARSpatialMeshUsageFlags SpatialMeshUsageFlags;
	///<summary>The frame number this tracked geometry was last updated on</summary>
	public int LastUpdateFrameNumber;
	///<summary>A unique name that can be used to identify the anchor for debug purposes</summary>
	public string DebugName;
}
