#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreServicesTypes.h")]
///<summary>@ingroup GoogleARCoreServices</summary>
public enum EARPinCloudTaskResult {
	Success=0,
	Failed=1,
	Started=2,
	CloudARPinNotEnabled=3,
	NotTracking=4,
	SessionPaused=5,
	InvalidPin=6,
	ResourceExhausted=7,
}
