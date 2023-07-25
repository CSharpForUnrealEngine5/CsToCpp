#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGSelfPruning.h")]
public enum EPCGSelfPruningType {
	LargeToSmall=0,
	SmallToLarge=1,
	AllEqual=2,
	None=3,
	RemoveDuplicates=4,
}
