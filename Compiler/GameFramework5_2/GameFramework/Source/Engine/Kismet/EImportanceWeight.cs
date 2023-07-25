#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/ImportanceSamplingLibrary.h")]
///<summary>Provides different weighting functions for texture importance sampling</summary>
public enum EImportanceWeight {
	Luminance=0,
	Red=1,
	Green=2,
	Blue=3,
	Alpha=4,
}
