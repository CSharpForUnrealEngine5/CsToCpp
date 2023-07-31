#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshModelingFunctions.h")]
public partial struct FGeometryScriptMeshOffsetOptions {
	public float OffsetDistance;
	public bool bFixedBoundary;
	public int SolveSteps;
	public float SmoothAlpha;
	public bool bReprojectDuringSmoothing;
	public float BoundaryAlpha;
}
