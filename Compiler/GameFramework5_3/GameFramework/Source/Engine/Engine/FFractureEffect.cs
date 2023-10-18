namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to hold effects for destructible damage events</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FFractureEffect {
	public UParticleSystem ParticleSystem;
	public USoundBase Sound;
}
