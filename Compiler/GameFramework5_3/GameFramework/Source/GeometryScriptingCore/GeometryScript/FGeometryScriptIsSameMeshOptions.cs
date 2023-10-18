namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshComparisonFunctions.h")]
public partial struct FGeometryScriptIsSameMeshOptions {
	public bool bCheckConnectivity;
	public bool bCheckEdgeIDs;
	public bool bCheckNormals;
	public bool bCheckColors;
	public bool bCheckUVs;
	public bool bCheckGroups;
	public bool bCheckAttributes;
	public float Epsilon;
}
