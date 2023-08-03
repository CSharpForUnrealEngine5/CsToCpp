#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Size/ParticleModuleSizeMultiplyLife.h")]
public partial class UParticleModuleSizeMultiplyLife : UParticleModuleSizeBase {
	public static UClass StaticClass() {return default;}
	///<summary>The scale factor for the size that should be used for a particle.</summary>
	public FRawDistributionVector LifeMultiplier;
	///<summary>If true, the X-component of the scale factor will be applied to the particle size X-component.</summary>
	public bool MultiplyX;
	///<summary>If true, the Y-component of the scale factor will be applied to the particle size Y-component.</summary>
	public bool MultiplyY;
	///<summary>If true, the Z-component of the scale factor will be applied to the particle size Z-component.</summary>
	public bool MultiplyZ;
}
