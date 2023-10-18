namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the Remesh operation</summary>
[CppInclude("RemeshMeshTool.h")]
public partial class URemeshMeshToolProperties : URemeshProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Target triangle count</summary>
	public int TargetTriangleCount;
	///<summary>Smoothing type</summary>
	public ERemeshSmoothingType SmoothingType;
	///<summary>Discard UVs and existing normals, allowing the remesher to ignore any UV and normal seams. New per-vertex normals are computed.</summary>
	public bool bDiscardAttributes;
	///<summary>Display colors corresponding to the mesh&#39;s polygon groups</summary>
	public bool bShowGroupColors;
	///<summary>Remeshing type</summary>
	public ERemeshType RemeshType;
	///<summary>Number of Remeshing passes</summary>
	public int RemeshIterations;
	///<summary>Maximum number of Remeshing passes, for Remeshers that have convergence criteria</summary>
	public int MaxRemeshIterations;
	///<summary>For NormalFlowRemesher: extra iterations of normal flow with no remeshing</summary>
	public int ExtraProjectionIterations;
	///<summary>If true, the target count is ignored and the target edge length is used directly</summary>
	public bool bUseTargetEdgeLength;
	///<summary>Remesh to have edges approximately this length. An attempt at a reasonable value is computed automatically for this field based on the selected target mesh.</summary>
	public float TargetEdgeLength;
	///<summary>Enable projection back to input mesh</summary>
	public bool bReproject;
	///<summary>Project constrained vertices back to original constraint curves</summary>
	public bool bReprojectConstraints;
	///<summary>Angle threshold in degrees for classifying a boundary vertex as a corner. Corners will be fixed if Reproject Constraints is active.</summary>
	public float BoundaryCornerAngleThreshold;
}
