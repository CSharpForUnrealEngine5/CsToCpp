#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosEngineInterface.h")]
///<summary>Enum for controlling the falloff of strength of a radial impulse as a function of distance from Origin.</summary>
public enum ERadialImpulseFalloff {
	RIF_Constant=0,
	RIF_Linear=1,
	RIF_MAX=2,
}
