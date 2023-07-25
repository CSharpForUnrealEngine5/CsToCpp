#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreFaceMeshComponent.h")]
///<summary>This component is updated by the ARSystem with face data on devices that have support for it.</summary>
public partial class UDEPRECATED_GoogleARCoreFaceMeshComponent : UProceduralMeshComponent {
// GoogleARCoreFaceMeshComponent
	public void CreateMesh(TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector2D> UV0) {}
	public void UpdateMesh(TArray<FVector> Vertices) {}
	public void SetAutoBind(bool bAutoBind) {}
	public void BindARFaceGeometry(UObject FaceGeometry) {}
	public FTransform GetTransform() { return default; }
	public bool bWantsCollision;
	public bool bAutoBindToLocalFaceMesh;
	public EARCoreFaceComponentTransformMixing TransformSetting;
	public UMaterialInterface FaceMaterial;
}
