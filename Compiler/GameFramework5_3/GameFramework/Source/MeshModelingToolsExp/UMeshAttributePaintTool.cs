namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMeshAttributePaintTool paints single-channel float attributes on a MeshDescription.</summary>
[CppInclude("MeshAttributePaintTool.h")]
public partial class UMeshAttributePaintTool : UDynamicMeshBrushTool {
	public static UClass StaticClass() {return default;}
	///<summary>BrushActionProps</summary>
	public UMeshAttributePaintBrushOperationProperties BrushActionProps;
	///<summary>AttribProps</summary>
	public UMeshAttributePaintToolProperties AttribProps;
}
