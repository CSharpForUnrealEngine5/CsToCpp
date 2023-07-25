#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/ContentBundle/ContentBundleClient.h")]
public enum EContentBundleClientState {
	Unregistered=0,
	Registered=1,
	ContentInjectionRequested=2,
	ContentRemovalRequested=3,
	RegistrationFailed=4,
}
