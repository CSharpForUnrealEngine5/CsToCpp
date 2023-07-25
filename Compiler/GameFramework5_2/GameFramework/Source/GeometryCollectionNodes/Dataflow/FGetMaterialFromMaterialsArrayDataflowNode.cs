#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionMaterialNodes.h")]
///<summary>Get a Material from a Materials array</summary>
public partial struct FGetMaterialFromMaterialsArrayDataflowNode {
// GetMaterialFromMaterialsArrayDataflowNode
	public TArray<UMaterial> Materials;
	public UMaterial Material;
	public int MaterialIdx;
}
