namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple tool to bake scene transform on meshes into the mesh assets</summary>
[CppInclude("BakeTransformTool.h")]
public partial class UBakeTransformTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>BasicProperties</summary>
	public UBakeTransformToolProperties BasicProperties;
}
