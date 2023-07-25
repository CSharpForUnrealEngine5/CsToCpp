#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Damage.h")]
public partial struct FAIDamageEvent {
// AIDamageEvent
	public float Amount;
	public FVector Location;
	public FVector HitLocation;
	public AActor DamagedActor;
	public AActor Instigator;
	public string Tag;
}
