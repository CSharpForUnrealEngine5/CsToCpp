#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AppleARKitFaceMeshComponent.h")]
///<summary>This component is updated by the ARSystem with face data on devices that have support for it</summary>
public partial class UAppleARKitFaceMeshComponent : UProceduralMeshComponent {
// AppleARKitFaceMeshComponent
	public  void CreateMesh(TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector2D> UV0) {}
	public  void SetBlendShapes(TMap<EARFaceBlendShape,float> InBlendShapes) {}
	public  void SetBlendShapeAmount(EARFaceBlendShape BlendShape,float Amount) {}
	public  float GetFaceBlendShapeAmount(EARFaceBlendShape BlendShape) { return default; }
	public  void UpdateMeshFromBlendShapes() {}
	public  void UpdateMesh(TArray<FVector> Vertices) {}
	public  void SetAutoBind(bool bAutoBind) {}
	public  int GetLastUpdateFrameNumber() { return default; }
	public  float GetLastUpdateTimestamp() { return default; }
	public  void PublishViaLiveLink(string SubjectName) {}
	public  FTransform GetTransform() { return default; }
	public bool bWantsMeshUpdates;
	public bool bWantsCollision;
	public bool bAutoBindToLocalFaceMesh;
	public EARFaceComponentTransformMixing TransformSetting;
	public bool bFlipTrackedRotation;
	public UMaterialInterface FaceMaterial;
	public string LiveLinkSubjectName;
	public TArray<FNetQuantizeFaceCurve> RemoteCurves;
	public  void OnRep_RemoteCurves() {}
	public  void ServerUpdateFaceCurves(TArray<FNetQuantizeFaceCurve> ClientCurves) {}
}
