#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionRampTopBottom.h")]
///<summary>A material expression that computes a top-to-bottom bilinear value ramp.</summary>
public partial class UMaterialExpressionRampTopBottom : UMaterialExpression {
// MaterialExpressionRampTopBottom
	public FExpressionInput Coordinates;
	public FExpressionInput A;
	public FExpressionInput B;
	public byte ConstCoordinate;
}
