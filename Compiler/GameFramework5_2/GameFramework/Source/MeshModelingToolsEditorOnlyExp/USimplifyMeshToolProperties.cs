#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SimplifyMeshTool.h")]
///<summary>Standard properties of the Simplify operation</summary>
public partial class USimplifyMeshToolProperties : UMeshConstraintProperties {
// SimplifyMeshToolProperties
	public ESimplifyType SimplifierType;
	public ESimplifyTargetType TargetMode;
	public int TargetPercentage;
	public float TargetEdgeLength;
	public int TargetTriangleCount;
	public int TargetVertexCount;
	public float MinimalAngleThreshold;
	public float PolyEdgeAngleTolerance;
	public bool bDiscardAttributes;
	public bool bGeometricConstraint;
	public float GeometricTolerance;
	public bool bShowGroupColors;
	public bool bReproject;
}
