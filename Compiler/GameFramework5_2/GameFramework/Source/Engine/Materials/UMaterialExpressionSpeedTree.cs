#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSpeedTree.h")]
public partial class UMaterialExpressionSpeedTree : UMaterialExpression {
// MaterialExpressionSpeedTree
	public FExpressionInput GeometryInput;
	public FExpressionInput WindInput;
	public FExpressionInput LODInput;
	public FExpressionInput ExtraBendWS;
	public ESpeedTreeGeometryType GeometryType;
	public ESpeedTreeWindType WindType;
	public ESpeedTreeLODType LODType;
	public float BillboardThreshold;
	public bool bAccurateWindVelocities;
}
