#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionRemap.h")]
///<summary>A material expression that Remap a value from one range to another.</summary>
public partial class UMaterialExpressionRemap : UMaterialExpression {
// MaterialExpressionRemap
	public FExpressionInput Input;
	public FExpressionInput InputLow;
	public FExpressionInput InputHigh;
	public FExpressionInput TargetLow;
	public FExpressionInput TargetHigh;
	public float InputLowDefault;
	public float InputHighDefault;
	public float TargetLowDefault;
	public float TargetHighDefault;
}
