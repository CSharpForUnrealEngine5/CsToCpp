namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generates a formatted string of materials from the Materials array</summary>
[CppInclude("Dataflow/GeometryCollectionMaterialNodes.h")]
public partial struct FMaterialsInfoDataflowNode {
	public TArray<UMaterial> Materials;
	public string String;
}
