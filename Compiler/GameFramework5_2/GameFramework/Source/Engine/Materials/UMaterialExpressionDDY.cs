#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDDY.h")]
public partial class UMaterialExpressionDDY : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>The value we want to compute ddx/ddy from</summary>
	public FExpressionInput Value;
}
