#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionSplitTopBottom.h")]
///<summary>A material expression that computes a top-bottom split matte, split at a specified v value.</summary>
public partial class UMaterialExpressionSplitTopBottom : UMaterialExpression {
// MaterialExpressionSplitTopBottom
	public FExpressionInput Coordinates;
	public FExpressionInput A;
	public FExpressionInput B;
	public FExpressionInput Center;
	public float ConstCenter;
	public byte ConstCoordinate;
}
