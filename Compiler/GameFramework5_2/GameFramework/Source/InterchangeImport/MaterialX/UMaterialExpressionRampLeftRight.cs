#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionRampLeftRight.h")]
///<summary>A material expression that computes a left-to-right bilinear value ramp.</summary>
public partial class UMaterialExpressionRampLeftRight : UMaterialExpression {
// MaterialExpressionRampLeftRight
	public FExpressionInput Coordinates;
	public FExpressionInput A;
	public FExpressionInput B;
	public byte ConstCoordinate;
}
