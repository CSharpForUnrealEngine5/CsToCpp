#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Set a Material in a Materials array</summary>
[CppInclude("Dataflow/GeometryCollectionMaterialNodes.h")]
public partial struct FSetMaterialInMaterialsArrayDataflowNode {
	public TArray<UMaterial> Materials;
	public UMaterial Material;
	public ESetMaterialOperationTypeEnum Operation;
	public int MaterialIdx;
}
