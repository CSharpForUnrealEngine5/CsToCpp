#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshRepairFunctions.h")]
public partial struct FGeometryScriptDegenerateTriangleOptions {
	public EGeometryScriptRepairMeshMode Mode;
	public double MinTriangleArea;
	public double MinEdgeLength;
	public bool bCompactOnCompletion;
}
