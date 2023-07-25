#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectSubsystem.h")]
///<summary>Struct used to find a smart object within a specific search range and with optional filtering</summary>
public partial struct FSmartObjectRequest {
// SmartObjectRequest
	public FBox QueryBox;
	public FSmartObjectRequestFilter Filter;
}
