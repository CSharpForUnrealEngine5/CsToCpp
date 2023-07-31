#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This component is updated by the ARSystem with face data on devices that have support for it</summary>
[CppInclude("AppleARKitFaceMeshComponent.h")]
public partial class UAppleARKitFaceMeshComponent : UProceduralMeshComponent {
	///<summary>Create the initial face mesh from raw mesh data</summary>
	public  void CreateMesh(TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector2D> UV0) {}
	///<summary>Set all of the blend shapes for this instance from a set of blend shapes</summary>
	public  void SetBlendShapes(TMap<EARFaceBlendShape,float> InBlendShapes) {}
	///<summary>Sets the amount for a given blend shape</summary>
	public  void SetBlendShapeAmount(EARFaceBlendShape BlendShape,float Amount) {}
	///<summary>Returns the value of the specified blend shape</summary>
	public  float GetFaceBlendShapeAmount(EARFaceBlendShape BlendShape) { return default; }
	///<summary>Create/replace the face mesh from the current set of blend shapes if the device supports it</summary>
	public  void UpdateMeshFromBlendShapes() {}
	///<summary>Updates the face mesh vertices. The topology and UVs do not change post creation so only vertices are updated</summary>
	public  void UpdateMesh(TArray<FVector> Vertices) {}
	///<summary>If auto bind is true, then this component will update itself from the local face tracking data each tick. If auto bind is off, ticking is disabled</summary>
	public  void SetAutoBind(bool bAutoBind) {}
	///<summary>Returns the frame number that was last used to update this component</summary>
	public  int GetLastUpdateFrameNumber() { return default; }
	///<summary>Returns the frame timestamp that was last used to update this component</summary>
	public  float GetLastUpdateTimestamp() { return default; }
	///<summary>Starts LiveLink publishing of this face component&#39;s data so that it can be used by the animation system</summary>
	public  void PublishViaLiveLink(string SubjectName) {}
	///<summary>Get the transform that the AR camera has detected</summary>
	public  FTransform GetTransform() { return default; }
	///<summary>Indicates whether the face mesh data should be built for rendering or not</summary>
	public bool bWantsMeshUpdates;
	///<summary>Indicates whether collision should be created for this face mesh. This adds significant cost, so only use if you need to trace against the face mesh.</summary>
	public bool bWantsCollision;
	///<summary>If true, the mesh data will come from the local ARKit face mesh data. The face mesh will update every tick and will handle loss of face tracking</summary>
	public bool bAutoBindToLocalFaceMesh;
	///<summary>Determines how the transform from tracking data and the component&#39;s transform are mixed together</summary>
	public EARFaceComponentTransformMixing TransformSetting;
	///<summary>If true, the face mesh will be rotated to face out of the screen (-X) rather than into the screen (+X) and corresponding axises to match</summary>
	public bool bFlipTrackedRotation;
	///<summary>Used when rendering the face mesh (mostly debug reasons)</summary>
	public UMaterialInterface FaceMaterial;
	///<summary>Used to identify this component&#39;s face ar data uniquely as part of the LiveLink animation pipeline</summary>
	public string LiveLinkSubjectName;
	///<summary>The set of changed curves to replicate to the other clients</summary>
	public TArray<FNetQuantizeFaceCurve> RemoteCurves;
	///<summary>Merges in the face curve deltas and pushes them to LiveLink</summary>
	public  void OnRep_RemoteCurves() {}
	///<summary>Sends the updated curves from the client to the server so that it can replicate to other clients</summary>
	public  void ServerUpdateFaceCurves(TArray<FNetQuantizeFaceCurve> ClientCurves) {}
}
