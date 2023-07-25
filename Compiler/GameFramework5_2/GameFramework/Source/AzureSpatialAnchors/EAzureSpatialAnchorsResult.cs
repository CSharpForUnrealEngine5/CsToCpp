#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsTypes.h")]
///<summary>Note: this Result enum must match AzureSpatialAnchorsInterop::AsyncResult in MixedRealityInterop.h</summary>
public enum EAzureSpatialAnchorsResult {
	Success=0,
	NotStarted=1,
	Started=2,
	FailAlreadyStarted=3,
	FailNoARPin=4,
	FailBadLocalAnchorID=5,
	FailBadCloudAnchorIdentifier=6,
	FailAnchorIdAlreadyUsed=7,
	FailAnchorDoesNotExist=8,
	FailAnchorAlreadyTracked=9,
	FailNoAnchor=10,
	FailNoCloudAnchor=11,
	FailNoLocalAnchor=12,
	FailNoSession=13,
	FailNoWatcher=14,
	FailNotEnoughData=15,
	FailBadLifetime=16,
	FailSeeErrorString=17,
	NotLocated=18,
	Canceled=19,
	FailUnknown=20,
}
