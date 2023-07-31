#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreTypes.h")]
///<summary>@ingroup GoogleARCoreBase</summary>
public enum EGoogleARCoreFunctionStatus {
	Success=0,
	Fatal=1,
	SessionPaused=2,
	NotTracking=3,
	ResourceExhausted=4,
	NotAvailable=5,
	InvalidType=6,
	IllegalState=7,
	Unknown=8,
}
