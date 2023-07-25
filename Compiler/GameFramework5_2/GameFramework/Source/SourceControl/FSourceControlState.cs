#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceControlHelpers.h")]
///<summary>Snapshot of source control state of a file</summary>
public partial struct FSourceControlState {
// SourceControlState
	public string Filename;
	public bool bIsValid;
	public bool bIsUnknown;
	public bool bCanCheckIn;
	public bool bCanCheckOut;
	public bool bIsCheckedOut;
	public bool bIsCurrent;
	public bool bIsSourceControlled;
	public bool bIsAdded;
	public bool bIsDeleted;
	public bool bIsIgnored;
	public bool bCanEdit;
	public bool bCanDelete;
	public bool bIsModified;
	public bool bCanAdd;
	public bool bIsConflicted;
	public bool bCanRevert;
	public bool bIsCheckedOutOther;
	public string CheckedOutOther;
}
