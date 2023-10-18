namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Orbit/ParticleModuleOrbit.h")]
public partial class UParticleModuleOrbit : UParticleModuleOrbitBase {
	public static UClass StaticClass() {return default;}
	///<summary>Orbit modules will chain together in the order they appear in the module stack.</summary>
	public EOrbitChainMode ChainMode;
	///<summary>The amount to offset the sprite from the particle position.</summary>
	public FRawDistributionVector OffsetAmount;
	///<summary>The options associated with the OffsetAmount look-up.</summary>
	public FOrbitOptions OffsetOptions;
	///<summary>The amount (in &#39;turns&#39;) to rotate the offset about the particle position.</summary>
	public FRawDistributionVector RotationAmount;
	///<summary>The options associated with the RotationAmount look-up.</summary>
	public FOrbitOptions RotationOptions;
	///<summary>The rate (in &#39;turns&#39;) at which to rotate the offset about the particle positon.</summary>
	public FRawDistributionVector RotationRateAmount;
	///<summary>The options associated with the RotationRateAmount look-up.</summary>
	public FOrbitOptions RotationRateOptions;
}
