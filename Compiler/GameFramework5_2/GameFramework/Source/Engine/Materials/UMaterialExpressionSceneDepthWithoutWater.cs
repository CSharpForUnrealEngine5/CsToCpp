#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSceneDepthWithoutWater.h")]
public partial class UMaterialExpressionSceneDepthWithoutWater : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Coordinates - UV coordinates to apply to the scene depth lookup.</summary>
	public EMaterialSceneAttributeInputMode InputMode;
	///<summary>Defaults to &#39;ConstInput&#39; if not specified</summary>
	public FExpressionInput Input;
	///<summary>only used if Input is not hooked up</summary>
	public FVector2D ConstInput;
	///<summary>Depth to fall back to in case the needed texture isn&#39;t available on a particular platform or configuration</summary>
	public float FallbackDepth;
}
