namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UShapeSprayTool is a brush-based tool that generates random points on the</summary>
[CppInclude("ShapeSprayTool.h")]
public partial class UShapeSprayTool : UDynamicMeshBrushTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UShapeSprayToolProperties Settings;
	///<summary>small meshes are accumulated here</summary>
	public UDynamicMeshComponent AccumMeshComponent;
}
