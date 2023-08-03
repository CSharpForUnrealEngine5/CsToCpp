#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionShadowReplace.h")]
public partial class UMaterialExpressionShadowReplace : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input will be used when rendering into non-ShadowMap passes</summary>
	public FExpressionInput Default;
	///<summary>Input will be used when rendering into ShadowMap</summary>
	public FExpressionInput Shadow;
}
