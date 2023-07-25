#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshRemeshFunctions.h")]
///<summary>Standard Remeshing Options</summary>
public partial struct FGeometryScriptRemeshOptions {
// GeometryScriptRemeshOptions
	public bool bDiscardAttributes;
	public bool bReprojectToInputMesh;
	public EGeometryScriptRemeshSmoothingType SmoothingType;
	public float SmoothingRate;
	public EGeometryScriptRemeshEdgeConstraintType MeshBoundaryConstraint;
	public EGeometryScriptRemeshEdgeConstraintType GroupBoundaryConstraint;
	public EGeometryScriptRemeshEdgeConstraintType MaterialBoundaryConstraint;
	public bool bAllowFlips;
	public bool bAllowSplits;
	public bool bAllowCollapses;
	public bool bPreventNormalFlips;
	public bool bPreventTinyTriangles;
	public bool bUseFullRemeshPasses;
	public int RemeshIterations;
	public bool bAutoCompact;
}
