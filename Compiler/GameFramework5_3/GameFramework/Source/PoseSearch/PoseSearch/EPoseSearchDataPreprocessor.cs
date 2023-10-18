namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseSearch/PoseSearchSchema.h")]
public enum EPoseSearchDataPreprocessor {
	None=0,
	Normalize=1,
	NormalizeOnlyByDeviation=2,
	Num=3,
	Invalid=-1,
}
