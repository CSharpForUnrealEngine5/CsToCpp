#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionSplitLeftRight.h")]
///<summary>A material expression that computes a left-right split matte, split at a specified u value.</summary>
public partial class UMaterialExpressionSplitLeftRight : UMaterialExpression {
// MaterialExpressionSplitLeftRight
	public FExpressionInput Coordinates;
	public FExpressionInput A;
	public FExpressionInput B;
	public FExpressionInput Center;
	public float ConstCenter;
	public byte ConstCoordinate;
}
