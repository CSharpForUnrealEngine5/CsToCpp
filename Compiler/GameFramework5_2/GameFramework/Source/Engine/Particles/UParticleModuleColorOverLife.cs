#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Color/ParticleModuleColorOverLife.h")]
public partial class UParticleModuleColorOverLife : UParticleModuleColorBase {
	public static UClass StaticClass() {return default;}
	///<summary>The color to apply to the particle, as a function of the particle RelativeTime.</summary>
	public FRawDistributionVector ColorOverLife;
	///<summary>The alpha to apply to the particle, as a function of the particle RelativeTime.</summary>
	public FRawDistributionFloat AlphaOverLife;
	///<summary>If true, the alpha value will be clamped to the [0..1] range.</summary>
	public bool bClampAlpha;
}
