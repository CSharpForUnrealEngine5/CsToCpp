namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the Simplify operation</summary>
[CppInclude("SimplifyMeshTool.h")]
public partial class USimplifyMeshToolProperties : UMeshConstraintProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Simplification Scheme</summary>
	public ESimplifyType SimplifierType;
	///<summary>Simplification Target Type</summary>
	public ESimplifyTargetType TargetMode;
	///<summary>Target percentage of original triangle count</summary>
	public int TargetPercentage;
	///<summary>Target edge length</summary>
	public float TargetEdgeLength;
	///<summary>Target triangle count</summary>
	public int TargetTriangleCount;
	///<summary>Target vertex count</summary>
	public int TargetVertexCount;
	///<summary>Angle threshold in degrees used for testing if two triangles should be considered coplanar, or two lines collinear</summary>
	public float MinimalAngleThreshold;
	///<summary>Threshold angle change (in degrees) along a polygroup edge, above which a vertex must be added</summary>
	public float PolyEdgeAngleTolerance;
	///<summary>Discard UVs and existing normals, allowing the simplifier to ignore any UV and normal seams. New per-vertex normals are computed.</summary>
	public bool bDiscardAttributes;
	///<summary>If true, then simplification will consider geometric deviation with the input mesh</summary>
	public bool bGeometricConstraint;
	///<summary>Geometric deviation tolerance used when bGeometricConstraint is enabled, to limit the geometric deviation between the simplified and original meshes</summary>
	public float GeometricTolerance;
	///<summary>Display colors corresponding to the mesh&#39;s polygon groups</summary>
	public bool bShowGroupColors;
	///<summary>Enable projection back to input mesh</summary>
	public bool bReproject;
}
