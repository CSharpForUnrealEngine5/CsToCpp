namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGDifferenceElement.h")]
public partial class UPCGDifferenceSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The density function to use when recalculating the density after the operation.</summary>
	public EPCGDifferenceDensityFunction DensityFunction;
	///<summary>Describes how the difference operation will treat the output data:</summary>
	public EPCGDifferenceMode Mode;
	///<summary>bDiffMetadata</summary>
	public bool bDiffMetadata;
	///<summary>If enabled, the output will not automatically filter out points with zero density.</summary>
	public bool bKeepZeroDensityPoints;
}
