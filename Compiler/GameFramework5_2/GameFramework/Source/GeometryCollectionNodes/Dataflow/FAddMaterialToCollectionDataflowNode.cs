#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionMaterialNodes.h")]
///<summary>Adds Outside/Inside Materials to Outside/Inside faces</summary>
public partial struct FAddMaterialToCollectionDataflowNode {
// AddMaterialToCollectionDataflowNode
	public FManagedArrayCollection Collection;
	public FDataflowFaceSelection FaceSelection;
	public TArray<UMaterial> Materials;
	public UMaterial OutsideMaterial;
	public UMaterial InsideMaterial;
	public bool bAssignOutsideMaterial;
	public bool bAssignInsideMaterial;
}
