#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshComparisonFunctions.h")]
public partial struct FGeometryScriptIsSameMeshOptions {
// GeometryScriptIsSameMeshOptions
	public bool bCheckConnectivity;
	public bool bCheckEdgeIDs;
	public bool bCheckNormals;
	public bool bCheckColors;
	public bool bCheckUVs;
	public bool bCheckGroups;
	public bool bCheckAttributes;
	public float Epsilon;
}
