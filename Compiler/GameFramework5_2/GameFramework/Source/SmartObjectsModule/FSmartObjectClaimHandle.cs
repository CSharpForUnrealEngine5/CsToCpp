#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectRuntime.h")]
///<summary>Struct describing a reservation between a user and a smart object slot.</summary>
public partial struct FSmartObjectClaimHandle {
// SmartObjectClaimHandle
	public FSmartObjectHandle SmartObjectHandle;
	public FSmartObjectSlotHandle SlotHandle;
	public FSmartObjectUserHandle UserHandle;
}
