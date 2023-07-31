#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSceneDepth.h")]
public partial class UMaterialExpressionSceneDepth : UMaterialExpression {
	///<summary>Coordinates - UV coordinates to apply to the scene depth lookup.</summary>
	public EMaterialSceneAttributeInputMode InputMode;
	///<summary>Defaults to &#39;ConstInput&#39; if not specified</summary>
	public FExpressionInput Input;
	///<summary>Coordinates_DEPRECATED</summary>
	public FExpressionInput Coordinates_DEPRECATED;
	///<summary>only used if Input is not hooked up</summary>
	public FVector2D ConstInput;
}
