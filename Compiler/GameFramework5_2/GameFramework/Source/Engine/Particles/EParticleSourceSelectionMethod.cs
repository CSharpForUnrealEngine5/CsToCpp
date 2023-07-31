#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleModule.h")]
///<summary>Particle Selection Method, for any emitters that utilize particles</summary>
public enum EParticleSourceSelectionMethod {
	EPSSM_Random=0,
	EPSSM_Sequential=1,
	EPSSM_MAX=2,
}
