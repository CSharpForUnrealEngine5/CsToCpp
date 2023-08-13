namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Color/ParticleModuleColorScaleOverLife.h")]
public partial class UParticleModuleColorScaleOverLife : UParticleModuleColorBase {
	public static UClass StaticClass() {return default;}
	///<summary>The scale factor for the color.</summary>
	public FRawDistributionVector ColorScaleOverLife;
	///<summary>The scale factor for the alpha.</summary>
	public FRawDistributionFloat AlphaScaleOverLife;
	///<summary>Whether it is EmitterTime or ParticleTime related.</summary>
	public bool bEmitterTime;
}
