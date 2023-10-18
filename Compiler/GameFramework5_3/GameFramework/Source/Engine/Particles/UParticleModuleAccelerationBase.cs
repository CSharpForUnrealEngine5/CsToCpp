namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Acceleration/ParticleModuleAccelerationBase.h")]
public partial class UParticleModuleAccelerationBase : UParticleModule {
	public static UClass StaticClass() {return default;}
	///<summary>If true, then treat the acceleration as world-space</summary>
	public bool bAlwaysInWorldSpace;
}
