#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchDatabase.h")]
public enum EPoseSearchMode {
	BruteForce=0,
	PCAKDTree=1,
	PCAKDTree_Validate=2,
	PCAKDTree_Compare=3,
	Num=4,
	Invalid=-1,
}
