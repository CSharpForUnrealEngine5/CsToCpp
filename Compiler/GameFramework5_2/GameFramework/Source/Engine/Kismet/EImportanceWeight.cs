namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/ImportanceSamplingLibrary.h")]
///<summary>Provides different weighting functions for texture importance sampling</summary>
[CppEnumInNamespace]
public enum EImportanceWeight {
	Luminance=0,
	Red=1,
	Green=2,
	Blue=3,
	Alpha=4,
}
