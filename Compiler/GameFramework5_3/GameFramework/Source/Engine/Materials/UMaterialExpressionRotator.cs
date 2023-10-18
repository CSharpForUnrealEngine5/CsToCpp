namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionRotator.h")]
public partial class UMaterialExpressionRotator : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;ConstCoordinate&#39; if not specified</summary>
	public FExpressionInput Coordinate;
	///<summary>Defaults to Game Time if not specified</summary>
	public FExpressionInput Time;
	///<summary>CenterX</summary>
	public float CenterX;
	///<summary>CenterY</summary>
	public float CenterY;
	///<summary>Speed</summary>
	public float Speed;
	///<summary>only used if Coordinate is not hooked up</summary>
	public uint ConstCoordinate;
}
