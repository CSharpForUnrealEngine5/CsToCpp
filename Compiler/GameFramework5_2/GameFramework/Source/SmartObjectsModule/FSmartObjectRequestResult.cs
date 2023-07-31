#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that holds the object and slot selected by processing a smart object request.</summary>
[CppInclude("SmartObjectSubsystem.h")]
public partial struct FSmartObjectRequestResult {
	public FSmartObjectHandle SmartObjectHandle;
	public FSmartObjectSlotHandle SlotHandle;
}
