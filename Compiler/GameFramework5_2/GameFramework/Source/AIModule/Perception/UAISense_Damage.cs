#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Damage.h")]
public partial class UAISense_Damage : UAISense {
// AISense_Damage
	public TArray<FAIDamageEvent> RegisteredEvents;
	public void ReportDamageEvent(UObject WorldContextObject,UObject DamagedActor,UObject Instigator,float DamageAmount,FVector EventLocation,FVector HitLocation,string Tag/*=NAME_None*/) {}
}
