#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MultiUserClientStatics.h")]
///<summary>Enum of the known Multi-User connection error, their value needs to match the internally returned error code.</summary>
public enum EMultiUserConnectionError {
	None=0,
	Canceled=1,
	ConnectionAttemptAborted=2,
	ServerNotResponding=3,
	ServerError=4,
	WorkspaceValidationUnknown=100,
	SourceControlValidationUnknown=110,
	SourceControlValidationCanceled=111,
	SourceControlValidationError=112,
	DirtyPackageValidationError=113,
}
