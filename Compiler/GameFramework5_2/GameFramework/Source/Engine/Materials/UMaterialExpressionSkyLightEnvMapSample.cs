#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
