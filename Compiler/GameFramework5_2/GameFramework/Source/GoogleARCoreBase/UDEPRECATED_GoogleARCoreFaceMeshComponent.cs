#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This component is updated by the ARSystem with face data on devices that have support for it.</summary>
[CppInclude("GoogleARCoreFaceMeshComponent.h")]
public partial class UDEPRECATED_GoogleARCoreFaceMeshComponent : UProceduralMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Create the initial face mesh from raw mesh data</summary>
	public  void CreateMesh(TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector2D> UV0) {}
	///<summary>Updates the face mesh vertices. The topology and UVs do not change post creation so only vertices are updated</summary>
	public  void UpdateMesh(TArray<FVector> Vertices) {}
	///<summary>If auto bind is true, then this component will update itself from the local face tracking data each tick.</summary>
	public  void SetAutoBind(bool bAutoBind) {}
	///<summary>Bind this FaceMeshComponent to the given UARFaceGeometry object.</summary>
	public  void BindARFaceGeometry(UARFaceGeometry FaceGeometry) {}
	///<summary>Get the transform that the AR camera has detected</summary>
	public  FTransform GetTransform() { return default; }
	///<summary>Indicates whether collision should be created for this face mesh. This adds significant cost, so only use if you need to trace against the face mesh.</summary>
	public bool bWantsCollision;
	///<summary>If true, the mesh data will come from the local ARKit face mesh data. The face mesh will update every tick and will handle loss of face tracking</summary>
	public bool bAutoBindToLocalFaceMesh;
	///<summary>Determines how the transform from tracking data and the component&#39;s transform are mixed together</summary>
	public EARCoreFaceComponentTransformMixing TransformSetting;
	///<summary>Used when rendering the face mesh (mostly debug reasons)</summary>
	public UMaterialInterface FaceMaterial;
}
