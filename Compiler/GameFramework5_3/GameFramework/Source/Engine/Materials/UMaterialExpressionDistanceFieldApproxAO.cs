namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDistanceFieldApproxAO.h")]
public partial class UMaterialExpressionDistanceFieldApproxAO : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to current world position if not specified</summary>
	public FExpressionInput Position;
	///<summary>Defaults to current world normal if not specified</summary>
	public FExpressionInput Normal;
	///<summary>BaseDistance</summary>
	public FExpressionInput BaseDistance;
	///<summary>only used if BaseDistance is not hooked up</summary>
	public float BaseDistanceDefault;
	///<summary>Radius</summary>
	public FExpressionInput Radius;
	///<summary>only used if Radius is not hooked up</summary>
	public float RadiusDefault;
	///<summary>Number of samples used to calculate occlusion</summary>
	public uint NumSteps;
	///<summary>Used to control step distance distribution</summary>
	public float StepScaleDefault;
}
