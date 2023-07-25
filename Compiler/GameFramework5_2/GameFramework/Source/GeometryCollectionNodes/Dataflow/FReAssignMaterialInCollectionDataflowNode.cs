#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionMaterialNodes.h")]
///<summary>Reassign existing material(s) to Outside/Inside faces</summary>
public partial struct FReAssignMaterialInCollectionDataflowNode {
// ReAssignMaterialInCollectionDataflowNode
	public FManagedArrayCollection Collection;
	public FDataflowFaceSelection FaceSelection;
	public TArray<UMaterial> Materials;
	public int OutsideMaterialIdx;
	public int InsideMaterialIdx;
	public bool bAssignOutsideMaterial;
	public bool bAssignInsideMaterial;
}
