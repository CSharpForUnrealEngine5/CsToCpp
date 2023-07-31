#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSceneColor.h")]
public partial class UMaterialExpressionSceneColor : UMaterialExpression {
	///<summary>Coordinates - UV coordinates to apply to the scene color lookup.</summary>
	public EMaterialSceneAttributeInputMode InputMode;
	///<summary>Defaults to &#39;ConstInput&#39; if not specified</summary>
	public FExpressionInput Input;
	///<summary>OffsetFraction_DEPRECATED</summary>
	public FExpressionInput OffsetFraction_DEPRECATED;
	///<summary>only used if Input is not hooked up</summary>
	public FVector2D ConstInput;
}
