namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreServicesTypes.h")]
///<summary>@ingroup GoogleARCoreServices</summary>
public enum ECloudARPinCloudState {
	NotHosted=0,
	InProgress=1,
	Cancelled=2,
	Success=3,
	ErrorInternalError=4,
	ErrorNotAuthorized=5,
	ErrorLocalizationFailure=6,
	ErrorServiceUnavailable=7,
	ErrorResourceExhausted=8,
	ErrorHostingDatasetProcessingFailed=9,
	ErrorResolvingCloudIDNotFound=10,
	ErrorSDKVersionTooOld=11,
	ErrorSDKVersionTooNew=12,
}
