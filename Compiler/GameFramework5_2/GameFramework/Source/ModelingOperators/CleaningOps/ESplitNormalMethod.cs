namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CleaningOps/EditNormalsOp.h")]
public enum ESplitNormalMethod {
	UseExistingTopology=0,
	FaceNormalThreshold=1,
	FaceGroupID=2,
	PerTriangle=3,
	PerVertex=4,
}
