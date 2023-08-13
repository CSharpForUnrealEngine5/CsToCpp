namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Size/ParticleModuleSizeScaleBySpeed.h")]
public partial class UParticleModuleSizeScaleBySpeed : UParticleModuleSizeBase {
	public static UClass StaticClass() {return default;}
	///<summary>By how much speed affects the size of the particle in each dimension.</summary>
	public FVector2D SpeedScale;
	///<summary>The maximum amount by which to scale a particle in each dimension.</summary>
	public FVector2D MaxScale;
}
