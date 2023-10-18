namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDistanceFieldGradient.h")]
public partial class UMaterialExpressionDistanceFieldGradient : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to current world position if not specified</summary>
	public FExpressionInput Position;
}
