namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard Remeshing Options</summary>
[CppInclude("GeometryScript/MeshRemeshFunctions.h")]
public partial struct FGeometryScriptRemeshOptions {
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
