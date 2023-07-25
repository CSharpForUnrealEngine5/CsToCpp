#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGDifferenceElement.h")]
public partial class UPCGDifferenceSettings : UPCGSettings {
// PCGDifferenceSettings
	public EPCGDifferenceDensityFunction DensityFunction;
	public EPCGDifferenceMode Mode;
	public bool bDiffMetadata;
	public bool bKeepZeroDensityPoints;
}
