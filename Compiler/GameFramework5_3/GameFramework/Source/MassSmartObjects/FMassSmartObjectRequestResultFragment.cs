namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fragment that holds the result of a request to find candidates.</summary>
[CppInclude("MassSmartObjectRequest.h")]
public partial struct FMassSmartObjectRequestResultFragment {
	public FMassSmartObjectCandidateSlots Candidates;
	public bool bProcessed;
}
