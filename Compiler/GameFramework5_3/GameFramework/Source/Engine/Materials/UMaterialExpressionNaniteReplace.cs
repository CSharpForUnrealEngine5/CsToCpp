namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionNaniteReplace.h")]
public partial class UMaterialExpressionNaniteReplace : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input will be used when rendering into non-Nanite passes</summary>
	public FExpressionInput Default;
	///<summary>Input will be used when rendering into Nanite passes</summary>
	public FExpressionInput Nanite;
}
