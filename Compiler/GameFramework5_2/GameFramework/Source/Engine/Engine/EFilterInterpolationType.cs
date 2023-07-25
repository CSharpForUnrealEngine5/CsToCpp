#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Interpolation method used by animation blending</summary>
public enum EFilterInterpolationType {
	BSIT_Average=0,
	BSIT_Linear=1,
	BSIT_Cubic=2,
	BSIT_EaseInOut=3,
	BSIT_ExponentialDecay=4,
	BSIT_SpringDamper=5,
	BSIT_MAX=6,
}
