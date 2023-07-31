#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Attractor/ParticleModuleAttractorLine.h")]
public partial class UParticleModuleAttractorLine : UParticleModuleAttractorBase {
	///<summary>The first endpoint of the line.</summary>
	public FVector EndPoint0;
	///<summary>The second endpoint of the line.</summary>
	public FVector EndPoint1;
	///<summary>The range of the line attractor.</summary>
	public FRawDistributionFloat Range;
	///<summary>The strength of the line attractor.</summary>
	public FRawDistributionFloat Strength;
}
