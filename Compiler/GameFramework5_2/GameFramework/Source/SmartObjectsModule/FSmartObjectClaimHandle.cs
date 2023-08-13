namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct describing a reservation between a user and a smart object slot.</summary>
[CppInclude("SmartObjectRuntime.h")]
public partial struct FSmartObjectClaimHandle {
	public FSmartObjectHandle SmartObjectHandle;
	public FSmartObjectSlotHandle SlotHandle;
	public FSmartObjectUserHandle UserHandle;
}
