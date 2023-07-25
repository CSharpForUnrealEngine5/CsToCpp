#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDepthOfFieldFunction.h")]
///<summary>Note: The index is used to map the enum to different code in the shader</summary>
public enum EDepthOfFieldFunctionValue {
	TDOF_NearAndFarMask=0,
	TDOF_NearMask=1,
	TDOF_FarMask=2,
	TDOF_CircleOfConfusionRadius=3,
	TDOF_MAX=4,
}
