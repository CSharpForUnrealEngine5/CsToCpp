namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDepthOfFieldFunction.h")]
public partial class UMaterialExpressionDepthOfFieldFunction : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Determines the mapping place to use on the terrain.</summary>
	public EDepthOfFieldFunctionValue FunctionValue;
	///<summary>usually nothing or PixelDepth</summary>
	public FExpressionInput Depth;
}
