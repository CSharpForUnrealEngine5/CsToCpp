#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectSubsystem.h")]
///<summary>Struct that holds the object and slot selected by processing a smart object request.</summary>
public partial struct FSmartObjectRequestResult {
// SmartObjectRequestResult
	public FSmartObjectHandle SmartObjectHandle;
	public FSmartObjectSlotHandle SlotHandle;
}
