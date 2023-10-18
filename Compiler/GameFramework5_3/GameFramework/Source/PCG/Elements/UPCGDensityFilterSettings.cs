namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGDensityFilter.h")]
public partial class UPCGDensityFilterSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>LowerBound</summary>
	public float LowerBound;
	///<summary>UpperBound</summary>
	public float UpperBound;
	///<summary>bInvertFilter</summary>
	public bool bInvertFilter;
	///<summary>bKeepZeroDensityPoints</summary>
	public bool bKeepZeroDensityPoints;
}
