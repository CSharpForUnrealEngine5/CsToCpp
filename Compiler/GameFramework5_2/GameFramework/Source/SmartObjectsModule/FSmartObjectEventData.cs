#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Strict describing a change in Smart Object or Slot.</summary>
[CppInclude("SmartObjectTypes.h")]
public partial struct FSmartObjectEventData {
	public FSmartObjectHandle SmartObjectHandle;
	public FSmartObjectSlotHandle SlotHandle;
	public ESmartObjectChangeReason Reason;
	public FGameplayTag Tag;
}
