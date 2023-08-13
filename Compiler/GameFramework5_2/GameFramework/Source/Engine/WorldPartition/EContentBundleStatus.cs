namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/ContentBundle/ContentBundleStatus.h")]
public enum EContentBundleStatus {
	Registered=0,
	ReadyToInject=1,
	FailedToInject=2,
	ContentInjected=3,
	Unknown=-1,
}
