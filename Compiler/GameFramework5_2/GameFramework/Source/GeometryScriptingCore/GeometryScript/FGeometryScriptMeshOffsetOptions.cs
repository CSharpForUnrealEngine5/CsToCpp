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
