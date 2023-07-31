#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBooleanFunctions.h")]
public partial struct FGeometryScriptMeshSelfUnionOptions {
	public bool bFillHoles;
	public bool bTrimFlaps;
	public bool bSimplifyOutput;
	public float SimplifyPlanarTolerance;
	public float WindingThreshold;
}
