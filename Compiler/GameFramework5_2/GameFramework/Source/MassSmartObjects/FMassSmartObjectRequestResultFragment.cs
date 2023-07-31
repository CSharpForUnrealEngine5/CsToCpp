#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fragment that holds the result of a request to find candidates.</summary>
[CppInclude("MassSmartObjectRequest.h")]
public partial struct FMassSmartObjectRequestResultFragment {
	public FMassSmartObjectCandidateSlots Candidates;
	public bool bProcessed;
}
