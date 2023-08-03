#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSmoothStep.h")]
public partial class UMaterialExpressionSmoothStep : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;ConstMin&#39; if not specified</summary>
	public FExpressionInput Min;
	///<summary>Defaults to &#39;ConstMax&#39; if not specified</summary>
	public FExpressionInput Max;
	///<summary>Defaults to &#39;ConstValue&#39; if not specified</summary>
	public FExpressionInput Value;
	///<summary>only used if Min is not hooked up</summary>
	public float ConstMin;
	///<summary>only used if Max is not hooked up</summary>
	public float ConstMax;
	///<summary>only used if Value is not hooked up</summary>
	public float ConstValue;
}
