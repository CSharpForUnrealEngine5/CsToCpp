namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGDifferenceElement.h")]
public partial class UPCGDifferenceSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>DensityFunction</summary>
	public EPCGDifferenceDensityFunction DensityFunction;
	///<summary>Mode</summary>
	public EPCGDifferenceMode Mode;
	///<summary>bDiffMetadata</summary>
	public bool bDiffMetadata;
	///<summary>bKeepZeroDensityPoints</summary>
	public bool bKeepZeroDensityPoints;
}
