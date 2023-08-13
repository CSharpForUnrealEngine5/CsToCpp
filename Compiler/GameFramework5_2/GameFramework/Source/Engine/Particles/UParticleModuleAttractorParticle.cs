namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Attractor/ParticleModuleAttractorParticle.h")]
public partial class UParticleModuleAttractorParticle : UParticleModuleAttractorBase {
	public static UClass StaticClass() {return default;}
	///<summary>The source emitter for attractors</summary>
	public string EmitterName;
	///<summary>The radial range of the attraction around the source particle.</summary>
	public FRawDistributionFloat Range;
	///<summary>The strength curve is a function of distance or of time.</summary>
	public bool bStrengthByDistance;
	///<summary>The strength of the attraction (negative values repel).</summary>
	public FRawDistributionFloat Strength;
	///<summary>If true, the velocity adjustment will be applied to the base velocity.</summary>
	public bool bAffectBaseVelocity;
	///<summary>The method to use when selecting an attractor target particle from the emitter.</summary>
	public EAttractorParticleSelectionMethod SelectionMethod;
	///<summary>Whether the particle should grab a new particle if it&#39;s source expires.</summary>
	public bool bRenewSource;
	///<summary>Whether the particle should inherit the source veloctiy if it expires.</summary>
	public bool bInheritSourceVel;
	///<summary>LastSelIndex</summary>
	public int LastSelIndex;
}
