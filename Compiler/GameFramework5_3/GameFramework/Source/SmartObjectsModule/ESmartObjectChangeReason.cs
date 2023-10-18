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
	OnOccupied=5,
	OnReleased=6,
	OnSlotEnabled=7,
	OnSlotDisabled=8,
	OnObjectEnabled=9,
	OnObjectDisabled=10,
}
