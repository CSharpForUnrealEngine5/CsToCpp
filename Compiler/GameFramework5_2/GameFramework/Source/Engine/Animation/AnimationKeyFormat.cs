#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimCompressionTypes.h")]
///<summary>Indicates animation data key format.</summary>
public enum AnimationKeyFormat {
	AKF_ConstantKeyLerp=0,
	AKF_VariableKeyLerp=1,
	AKF_PerTrackCompression=2,
	AKF_MAX=3,
}
