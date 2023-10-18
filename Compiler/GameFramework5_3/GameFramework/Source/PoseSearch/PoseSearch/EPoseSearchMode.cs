namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchDatabase.h")]
///<summary>namespace UE::PoseSearch</summary>
public enum EPoseSearchMode {
	BruteForce=0,
	PCAKDTree=1,
	PCAKDTree_Validate=2,
	PCAKDTree_Compare=3,
	Num=4,
	Invalid=-1,
}
