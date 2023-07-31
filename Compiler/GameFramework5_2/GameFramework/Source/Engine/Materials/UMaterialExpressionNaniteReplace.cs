#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionNaniteReplace.h")]
public partial class UMaterialExpressionNaniteReplace : UMaterialExpression {
	///<summary>Input will be used when rendering into non-Nanite passes</summary>
	public FExpressionInput Default;
	///<summary>Input will be used when rendering into Nanite passes</summary>
	public FExpressionInput Nanite;
}
