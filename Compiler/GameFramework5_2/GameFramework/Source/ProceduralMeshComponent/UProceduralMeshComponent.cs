namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component that allows you to specify custom triangle mesh geometry</summary>
[CppInclude("ProceduralMeshComponent.h")]
public partial class UProceduralMeshComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Create/replace a section for this procedural mesh component.</summary>
	public void CreateMeshSection(int SectionIndex,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<FVector2D> UV0,TArray<FColor> VertexColors,TArray<FProcMeshTangent> Tangents,bool bCreateCollision) {}
	///<summary>Create/replace a section for this procedural mesh component.</summary>
	public void CreateMeshSection_LinearColor(int SectionIndex,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<FVector2D> UV0,TArray<FVector2D> UV1,TArray<FVector2D> UV2,TArray<FVector2D> UV3,TArray<FLinearColor> VertexColors,TArray<FProcMeshTangent> Tangents,bool bCreateCollision,bool bSRGBConversion/*=false*/) {}
	///<summary>Updates a section of this procedural mesh component. This is faster than CreateMeshSection, but does not let you change topology. Collision info is also updated.</summary>
	public void UpdateMeshSection(int SectionIndex,TArray<FVector> Vertices,TArray<FVector> Normals,TArray<FVector2D> UV0,TArray<FColor> VertexColors,TArray<FProcMeshTangent> Tangents) {}
	///<summary>Updates a section of this procedural mesh component. This is faster than CreateMeshSection, but does not let you change topology. Collision info is also updated.</summary>
	public void UpdateMeshSection_LinearColor(int SectionIndex,TArray<FVector> Vertices,TArray<FVector> Normals,TArray<FVector2D> UV0,TArray<FVector2D> UV1,TArray<FVector2D> UV2,TArray<FVector2D> UV3,TArray<FLinearColor> VertexColors,TArray<FProcMeshTangent> Tangents,bool bSRGBConversion/*=true*/) {}
	///<summary>Clear a section of the procedural mesh. Other sections do not change index.</summary>
	public void ClearMeshSection(int SectionIndex) {}
	///<summary>Clear all mesh sections and reset to empty state</summary>
	public void ClearAllMeshSections() {}
	///<summary>Control visibility of a particular section</summary>
	public void SetMeshSectionVisible(int SectionIndex,bool bNewVisibility) {}
	///<summary>Returns whether a particular section is currently visible</summary>
	public bool IsMeshSectionVisible(int SectionIndex) { return default; }
	///<summary>Returns number of sections currently created for this component</summary>
	public int GetNumSections() { return default; }
	///<summary>Add simple collision convex to this component</summary>
	public void AddCollisionConvexMesh(TArray<FVector> ConvexVerts) {}
	///<summary>Remove collision meshes from this component</summary>
	public void ClearCollisionConvexMeshes() {}
	///<summary>Controls whether the complex (Per poly) geometry should be treated as &#39;simple&#39; collision.</summary>
	public bool bUseComplexAsSimpleCollision;
	///<summary>Controls whether the physics cooking should be done off the game thread. This should be used when collision geometry doesn&#39;t have to be immediately up to date (For example streaming in far away objects)</summary>
	public bool bUseAsyncCooking;
	///<summary>Collision data</summary>
	public UBodySetup ProcMeshBodySetup;
	///<summary>Array of sections of mesh</summary>
	public TArray<FProcMeshSection> ProcMeshSections;
	///<summary>Convex shapes used for simple collision</summary>
	public TArray<FKConvexElem> CollisionConvexElems;
	///<summary>Local space bounds of mesh</summary>
	public FBoxSphereBounds LocalBounds;
	///<summary>Queue for async body setups that are being cooked</summary>
	public TArray<UBodySetup> AsyncBodySetupQueue;
}
