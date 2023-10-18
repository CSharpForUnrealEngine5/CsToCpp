namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshRepairFunctions.h")]
public partial struct FGeometryScriptDegenerateTriangleOptions {
	public EGeometryScriptRepairMeshMode Mode;
	public double MinTriangleArea;
	public double MinEdgeLength;
	public bool bCompactOnCompletion;
}
