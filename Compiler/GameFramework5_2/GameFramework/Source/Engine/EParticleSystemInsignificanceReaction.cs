#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ParticleHelper.h")]
///<summary>Determines what a particle system will do when all of it&#39;s emitters become insignificant.</summary>
public enum EParticleSystemInsignificanceReaction {
	Auto=0,
	Complete=1,
	DisableTick=2,
	DisableTickAndKill=3,
	Num=4,
}
