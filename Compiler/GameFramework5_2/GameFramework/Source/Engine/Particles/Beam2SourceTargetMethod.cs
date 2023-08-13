namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Beam/ParticleModuleBeamBase.h")]
///<summary>The method to use in determining the source/target.</summary>
public enum Beam2SourceTargetMethod {
	PEB2STM_Default=0,
	PEB2STM_UserSet=1,
	PEB2STM_Emitter=2,
	PEB2STM_Particle=3,
	PEB2STM_Actor=4,
	PEB2STM_MAX=5,
}
