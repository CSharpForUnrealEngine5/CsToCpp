namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds Outside/Inside Materials to Outside/Inside faces</summary>
[CppInclude("Dataflow/GeometryCollectionMaterialNodes.h")]
public partial struct FAddMaterialToCollectionDataflowNode {
	public FManagedArrayCollection Collection;
	public FDataflowFaceSelection FaceSelection;
	public TArray<UMaterial> Materials;
	public UMaterial OutsideMaterial;
	public UMaterial InsideMaterial;
	public bool bAssignOutsideMaterial;
	public bool bAssignInsideMaterial;
}
