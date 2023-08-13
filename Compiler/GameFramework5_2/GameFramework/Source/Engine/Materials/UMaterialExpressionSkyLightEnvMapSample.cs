namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSkyLightEnvMapSample.h")]
public partial class UMaterialExpressionSkyLightEnvMapSample : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>The direction to sample the cubemap from</summary>
	public FExpressionInput Direction;
	///<summary>The roughness used to specifiy the sharpness of the sample.</summary>
	public FExpressionInput Roughness;
}
