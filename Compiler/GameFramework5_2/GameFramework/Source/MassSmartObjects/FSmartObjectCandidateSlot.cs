#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that represents a potential smart object slot for a MassEntity during the search</summary>
[CppInclude("MassSmartObjectRequest.h")]
public partial struct FSmartObjectCandidateSlot {
	public FSmartObjectRequestResult Result;
	public float Cost;
}
