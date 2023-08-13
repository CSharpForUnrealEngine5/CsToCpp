namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Collision/ParticleModuleCollisionBase.h")]
///<summary>Flags indicating what to do with the particle when MaxCollisions is reached</summary>
public enum EParticleCollisionComplete {
	EPCC_Kill=0,
	EPCC_Freeze=1,
	EPCC_HaltCollisions=2,
	EPCC_FreezeTranslation=3,
	EPCC_FreezeRotation=4,
	EPCC_FreezeMovement=5,
	EPCC_MAX=6,
}
