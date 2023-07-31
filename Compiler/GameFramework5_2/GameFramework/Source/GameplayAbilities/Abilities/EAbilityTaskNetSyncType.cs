#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_NetworkSyncPoint.h")]
public enum EAbilityTaskNetSyncType {
	BothWait=0,
	OnlyServerWait=1,
	OnlyClientWait=2,
}
