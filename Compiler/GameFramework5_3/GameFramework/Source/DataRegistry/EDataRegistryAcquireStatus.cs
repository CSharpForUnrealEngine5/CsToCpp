namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataRegistryTypes.h")]
///<summary>State of a registry async request</summary>
public enum EDataRegistryAcquireStatus {
	NotStarted=0,
	WaitingForInitialAcquire=1,
	InitialAcquireFinished=2,
	WaitingForResources=3,
	AcquireFinished=4,
	AcquireError=5,
	DoesNotExist=6,
}
