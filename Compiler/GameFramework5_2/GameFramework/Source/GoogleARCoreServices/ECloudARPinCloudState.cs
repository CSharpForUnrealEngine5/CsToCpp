#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreServicesTypes.h")]
///<summary>@ingroup GoogleARCoreServices</summary>
public enum ECloudARPinCloudState {
	NotHosted=0,
	InProgress=1,
	Success=2,
	ErrorInternalError=3,
	ErrorNotAuthorized=4,
	ErrorLocalizationFailure=5,
	ErrorServiceUnavailable=6,
	ErrorResourceExhausted=7,
	ErrorHostingDatasetProcessingFailed=8,
	ErrorResolvingCloudIDNotFound=9,
	ErrorSDKVersionTooOld=10,
	ErrorSDKVersionTooNew=11,
}
