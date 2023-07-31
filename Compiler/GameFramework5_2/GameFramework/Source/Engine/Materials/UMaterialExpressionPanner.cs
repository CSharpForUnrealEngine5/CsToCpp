#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionPanner.h")]
public partial class UMaterialExpressionPanner : UMaterialExpression {
	///<summary>Defaults to &#39;ConstCoordinate&#39; if not specified</summary>
	public FExpressionInput Coordinate;
	///<summary>Defaults to Game Time if not specified</summary>
	public FExpressionInput Time;
	///<summary>Vector2 speed scale, if specified</summary>
	public FExpressionInput Speed;
	///<summary>SpeedX</summary>
	public float SpeedX;
	///<summary>SpeedY</summary>
	public float SpeedY;
	///<summary>only used if Coordinate is not hooked up</summary>
	public uint ConstCoordinate;
	///<summary>Output only the fractional part of the pan calculation for greater precision.</summary>
	public bool bFractionalPart;
}
