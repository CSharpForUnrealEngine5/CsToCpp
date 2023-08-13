namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Collision/ParticleModuleCollisionGPU.h")]
///<summary>How particles respond to collision events.</summary>
[CppEnumInNamespace]
public enum EParticleCollisionResponse {
	Bounce=0,
	Stop=1,
	Kill=2,
}
