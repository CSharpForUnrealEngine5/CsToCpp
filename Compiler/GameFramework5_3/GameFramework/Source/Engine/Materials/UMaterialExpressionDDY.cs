namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDDY.h")]
public partial class UMaterialExpressionDDY : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>The value we want to compute ddx/ddy from</summary>
	public FExpressionInput Value;
}
