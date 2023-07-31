#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Non instanced GameplayCueNotify for spawning particle and sound FX.</summary>
[CppInclude("GameplayCueNotify_HitImpact.h")]
public partial class UGameplayCueNotify_HitImpact : UGameplayCueNotify_Static {
	///<summary>Sound</summary>
	public USoundBase Sound;
	///<summary>Effects to play for weapon attacks against specific surfaces</summary>
	public UParticleSystem ParticleSystem;
}
