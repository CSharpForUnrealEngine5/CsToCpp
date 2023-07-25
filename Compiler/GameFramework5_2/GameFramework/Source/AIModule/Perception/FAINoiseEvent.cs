#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Hearing.h")]
public partial struct FAINoiseEvent {
// AINoiseEvent
	public FVector NoiseLocation;
	public float Loudness;
	public float MaxRange;
	public AActor Instigator;
	public string Tag;
}
