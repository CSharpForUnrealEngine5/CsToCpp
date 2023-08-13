namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to find a smart object within a specific search range and with optional filtering</summary>
[CppInclude("SmartObjectSubsystem.h")]
public partial struct FSmartObjectRequest {
	public FBox QueryBox;
	public FSmartObjectRequestFilter Filter;
}
