#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProceduralMeshComponent.h")]
///<summary>Component that allows you to specify custom triangle mesh geometry</summary>
public partial class UProceduralMeshComponent : UMeshComponent {
// ProceduralMeshComponent
	public  void CreateMeshSection(int SectionIndex,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<FVector2D> UV0,TArray<FColor> VertexColors,TArray<FProcMeshTangent> Tangents,bool bCreateCollision) {}
	public  void CreateMeshSection_LinearColor(int SectionIndex,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<FVector2D> UV0,TArray<FVector2D> UV1,TArray<FVector2D> UV2,TArray<FVector2D> UV3,TArray<FLinearColor> VertexColors,TArray<FProcMeshTangent> Tangents,bool bCreateCollision,bool bSRGBConversion/*=false*/) {}
	public  void UpdateMeshSection(int SectionIndex,TArray<FVector> Vertices,TArray<FVector> Normals,TArray<FVector2D> UV0,TArray<FColor> VertexColors,TArray<FProcMeshTangent> Tangents) {}
	public  void UpdateMeshSection_LinearColor(int SectionIndex,TArray<FVector> Vertices,TArray<FVector> Normals,TArray<FVector2D> UV0,TArray<FVector2D> UV1,TArray<FVector2D> UV2,TArray<FVector2D> UV3,TArray<FLinearColor> VertexColors,TArray<FProcMeshTangent> Tangents,bool bSRGBConversion/*=true*/) {}
	public  void ClearMeshSection(int SectionIndex) {}
	public  void ClearAllMeshSections() {}
	public  void SetMeshSectionVisible(int SectionIndex,bool bNewVisibility) {}
	public  bool IsMeshSectionVisible(int SectionIndex) { return default; }
	public  int GetNumSections() { return default; }
	public  void AddCollisionConvexMesh(TArray<FVector> ConvexVerts) {}
	public  void ClearCollisionConvexMeshes() {}
	public bool bUseComplexAsSimpleCollision;
	public bool bUseAsyncCooking;
	public UBodySetup ProcMeshBodySetup;
	public TArray<FProcMeshSection> ProcMeshSections;
	public TArray<FKConvexElem> CollisionConvexElems;
	public FBoxSphereBounds LocalBounds;
	public TArray<UBodySetup> AsyncBodySetupQueue;
}
