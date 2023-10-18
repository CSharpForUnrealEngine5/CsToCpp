namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSelectionFunctions.h")]
///<summary>Types of connection between adjacent Mesh Elements (vertices/triangles/polygoups)</summary>
public enum EGeometryScriptTopologyConnectionType {
	Geometric=0,
	Polygroup=1,
	MaterialID=2,
}
