#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGDensityFilter.h")]
public partial class UPCGDensityFilterSettings : UPCGSettings {
// PCGDensityFilterSettings
	public float LowerBound;
	public float UpperBound;
	public bool bInvertFilter;
	public bool bKeepZeroDensityPoints;
}
