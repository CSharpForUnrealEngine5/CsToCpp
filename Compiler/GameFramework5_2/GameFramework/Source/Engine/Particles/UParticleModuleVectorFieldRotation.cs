#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/VectorField/ParticleModuleVectorFieldRotation.h")]
public partial class UParticleModuleVectorFieldRotation : UParticleModuleVectorFieldBase {
	public static UClass StaticClass() {return default;}
	///<summary>Minimum initial rotation applied to the local vector field.</summary>
	public FVector MinInitialRotation;
	///<summary>Maximum initial rotation applied to the local vector field.</summary>
	public FVector MaxInitialRotation;
}
