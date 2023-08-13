namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGPointSampler.h")]
public partial class UPCGPointSamplerSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Ratio</summary>
	public float Ratio;
	///<summary>bKeepZeroDensityPoints</summary>
	public bool bKeepZeroDensityPoints;
}
