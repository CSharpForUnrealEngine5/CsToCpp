#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionPanner.h")]
public partial class UMaterialExpressionPanner : UMaterialExpression {
// MaterialExpressionPanner
	public FExpressionInput Coordinate;
	public FExpressionInput Time;
	public FExpressionInput Speed;
	public float SpeedX;
	public float SpeedY;
	public uint ConstCoordinate;
	public bool bFractionalPart;
}
