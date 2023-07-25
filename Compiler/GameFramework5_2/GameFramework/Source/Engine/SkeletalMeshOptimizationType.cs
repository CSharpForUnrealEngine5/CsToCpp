#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SkeletalMeshReductionSettings.h")]
///<summary>Enum specifying the reduction type to use when simplifying skeletal meshes with Simmplygon</summary>
public enum SkeletalMeshOptimizationType {
	SMOT_NumOfTriangles=0,
	SMOT_MaxDeviation=1,
	SMOT_TriangleOrDeviation=2,
	SMOT_MAX=3,
}
