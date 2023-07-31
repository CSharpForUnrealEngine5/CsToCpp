#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UShapeSprayTool is a brush-based tool that generates random points on the</summary>
[CppInclude("ShapeSprayTool.h")]
public partial class UShapeSprayTool : UDynamicMeshBrushTool {
	///<summary>Settings</summary>
	public UShapeSprayToolProperties Settings;
	///<summary>small meshes are accumulated here</summary>
	public UDynamicMeshComponent AccumMeshComponent;
}
