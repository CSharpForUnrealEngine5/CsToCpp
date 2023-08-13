namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshVoxelFunctions.h")]
public partial struct FGeometryScriptSolidifyOptions {
	public FGeometryScript3DGridParameters GridParameters;
	public float WindingThreshold;
	public bool bSolidAtBoundaries;
	public float ExtendBounds;
	public int SurfaceSearchSteps;
	public bool bThickenShells;
	public double ShellThickness;
}
