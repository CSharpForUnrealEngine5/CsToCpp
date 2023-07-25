#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectTypes.h")]
///<summary>Strict describing a change in Smart Object or Slot.</summary>
public partial struct FSmartObjectEventData {
// SmartObjectEventData
	public FSmartObjectHandle SmartObjectHandle;
	public FSmartObjectSlotHandle SlotHandle;
	public ESmartObjectChangeReason Reason;
	public FGameplayTag Tag;
}
