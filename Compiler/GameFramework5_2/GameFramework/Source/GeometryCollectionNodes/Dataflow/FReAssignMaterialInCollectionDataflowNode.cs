namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Reassign existing material(s) to Outside/Inside faces</summary>
[CppInclude("Dataflow/GeometryCollectionMaterialNodes.h")]
public partial struct FReAssignMaterialInCollectionDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowFaceSelection FaceSelection;
	public TArray<UMaterial> Materials;
	public int OutsideMaterialIdx;
	public int InsideMaterialIdx;
	public bool bAssignOutsideMaterial;
	public bool bAssignInsideMaterial;
}
