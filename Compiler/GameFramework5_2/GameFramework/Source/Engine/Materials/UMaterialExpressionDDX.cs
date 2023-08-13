namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDDX.h")]
public partial class UMaterialExpressionDDX : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>The value we want to compute ddx/ddy from</summary>
	public FExpressionInput Value;
}
