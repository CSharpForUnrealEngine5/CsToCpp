#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/PathFollowingComponent.h")]
public enum EPathFollowingResult {
	Success=0,
	Blocked=1,
	OffPath=2,
	Aborted=3,
	Skipped_DEPRECATED=4,
	Invalid=5,
}
