#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectTypes.h")]
///<summary>Describes how Smart Object or slot was changed.</summary>
public enum ESmartObjectChangeReason {
	None=0,
	OnEvent=1,
	OnTagAdded=2,
	OnTagRemoved=3,
	OnClaimed=4,
	OnReleased=5,
	OnEnabled=6,
	OnDisabled=7,
}
