namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Acceleration/ParticleModuleAccelerationConstant.h")]
public partial class UParticleModuleAccelerationConstant : UParticleModuleAccelerationBase {
	public static UClass StaticClass() {return default;}
	///<summary>Constant acceleration for particles in this system.</summary>
	public FVector Acceleration;
}
