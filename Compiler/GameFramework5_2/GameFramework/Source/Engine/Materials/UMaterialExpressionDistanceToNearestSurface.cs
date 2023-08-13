namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDistanceToNearestSurface.h")]
public partial class UMaterialExpressionDistanceToNearestSurface : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to current world position if not specified</summary>
	public FExpressionInput Position;
}
