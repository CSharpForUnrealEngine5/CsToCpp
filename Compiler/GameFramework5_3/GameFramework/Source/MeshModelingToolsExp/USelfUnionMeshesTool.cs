namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Union of meshes, resolving self intersections</summary>
[CppInclude("SelfUnionMeshesTool.h")]
public partial class USelfUnionMeshesTool : UBaseCreateFromSelectedTool {
	public static UClass StaticClass() {return default;}
	///<summary>Properties</summary>
	public USelfUnionMeshesToolProperties Properties;
	///<summary>DrawnLineSet</summary>
	public ULineSetComponent DrawnLineSet;
}
