#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Attractor/ParticleModuleAttractorPointGravity.h")]
public partial class UParticleModuleAttractorPointGravity : UParticleModuleAttractorBase {
	public static UClass StaticClass() {return default;}
	///<summary>The position of the point gravity source.</summary>
	public FVector Position;
	///<summary>The distance at which the influence of the point begins to falloff.</summary>
	public float Radius;
	///<summary>The strength of the point source.</summary>
	public UDistributionFloat Strength_DEPRECATED;
	///<summary>The strength of the point source.</summary>
	public FRawDistributionFloat StrengthRaw;
}
