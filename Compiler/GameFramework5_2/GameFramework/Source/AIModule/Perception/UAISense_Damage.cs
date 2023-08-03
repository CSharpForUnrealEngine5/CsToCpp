#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISense_Damage.h")]
public partial class UAISense_Damage : UAISense {
	public static UClass StaticClass() {return default;}
	///<summary>RegisteredEvents</summary>
	public TArray<FAIDamageEvent> RegisteredEvents;
	///<summary>EventLocation will be reported as Instigator&#39;s location at the moment of event happening</summary>
	public static void ReportDamageEvent(UObject WorldContextObject,AActor DamagedActor,AActor Instigator,float DamageAmount,FVector EventLocation,FVector HitLocation,string Tag/*=NAME_None*/) {}
}
