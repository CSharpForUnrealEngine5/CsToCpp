namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMeshReductionSettings.h")]
///<summary>Enum specifying the reduction type to use when simplifying skeletal meshes with internal tool</summary>
public enum SkeletalMeshTerminationCriterion {
	SMTC_NumOfTriangles=0,
	SMTC_NumOfVerts=1,
	SMTC_TriangleOrVert=2,
	SMTC_AbsNumOfTriangles=3,
	SMTC_AbsNumOfVerts=4,
	SMTC_AbsTriangleOrVert=5,
	SMTC_MAX=6,
}
