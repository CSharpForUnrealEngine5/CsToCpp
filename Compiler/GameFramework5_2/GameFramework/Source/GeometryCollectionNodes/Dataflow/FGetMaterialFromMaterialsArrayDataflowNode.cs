namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Get a Material from a Materials array</summary>
[CppInclude("Dataflow/GeometryCollectionMaterialNodes.h")]
public partial struct FGetMaterialFromMaterialsArrayDataflowNode {
	public TArray<UMaterial> Materials;
	public UMaterial Material;
	public int MaterialIdx;
}
