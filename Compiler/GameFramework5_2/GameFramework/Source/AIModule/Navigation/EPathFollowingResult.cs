#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/PathFollowingComponent.h")]
[CppEnumInNamespace]
public enum EPathFollowingResult {
	Success=0,
	Blocked=1,
	OffPath=2,
	Aborted=3,
	Skipped_DEPRECATED=4,
	Invalid=5,
}
