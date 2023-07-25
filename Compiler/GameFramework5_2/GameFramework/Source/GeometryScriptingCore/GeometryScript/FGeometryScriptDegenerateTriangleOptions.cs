#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshRepairFunctions.h")]
public partial struct FGeometryScriptDegenerateTriangleOptions {
// GeometryScriptDegenerateTriangleOptions
	public EGeometryScriptRepairMeshMode Mode;
	public double MinTriangleArea;
	public double MinEdgeLength;
	public bool bCompactOnCompletion;
}
