#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionMaterialNodes.h")]
///<summary>Set a Material in a Materials array</summary>
public partial struct FSetMaterialInMaterialsArrayDataflowNode {
// SetMaterialInMaterialsArrayDataflowNode
	public TArray<UMaterial> Materials;
	public UMaterial Material;
	public ESetMaterialOperationTypeEnum Operation;
	public int MaterialIdx;
}
