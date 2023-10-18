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
