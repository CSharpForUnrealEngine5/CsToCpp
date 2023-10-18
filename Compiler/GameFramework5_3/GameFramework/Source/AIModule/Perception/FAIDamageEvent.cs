namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Damage.h")]
public partial struct FAIDamageEvent {
	public float Amount;
	public FVector Location;
	public FVector HitLocation;
	public AActor DamagedActor;
	public AActor Instigator;
	public FName Tag;
}
