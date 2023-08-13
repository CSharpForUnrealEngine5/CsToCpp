namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event used by AActor::TakeDamage and related functions</summary>
[CppInclude("Engine/DamageEvents.h")]
public partial struct FDamageEvent {
	public UClass DamageTypeClass;
}
