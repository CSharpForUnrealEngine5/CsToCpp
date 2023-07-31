#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTargetTypes.h")]
///<summary>These are generic, nonpayload carrying events that are replicated between the client and server</summary>
[CppEnumInNamespace]
public enum EAbilityGenericReplicatedEvent {
	GenericConfirm=0,
	GenericCancel=1,
	InputPressed=2,
	InputReleased=3,
	GenericSignalFromClient=4,
	GenericSignalFromServer=5,
	GameCustom1=6,
	GameCustom2=7,
	GameCustom3=8,
	GameCustom4=9,
	GameCustom5=10,
	GameCustom6=11,
	MAX=12,
}
