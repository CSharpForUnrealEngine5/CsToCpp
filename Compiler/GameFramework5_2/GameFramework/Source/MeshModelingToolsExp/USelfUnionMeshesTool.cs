#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Union of meshes, resolving self intersections</summary>
[CppInclude("SelfUnionMeshesTool.h")]
public partial class USelfUnionMeshesTool : UBaseCreateFromSelectedTool {
	///<summary>Properties</summary>
	public USelfUnionMeshesToolProperties Properties;
	///<summary>DrawnLineSet</summary>
	public ULineSetComponent DrawnLineSet;
}
