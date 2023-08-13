namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Output/VCamOutputMediaOutput.h")]
public partial class UVCamOutputMediaOutput : UVCamOutputProviderBase {
	public static UClass StaticClass() {return default;}
	///<summary>Media Output configuration asset</summary>
	public UMediaOutput OutputConfig;
	///<summary>If using the output from a Composure Output Provider, specify it here</summary>
	public int FromComposureOutputProviderIndex;
	///<summary>MediaCapture</summary>
	public UMediaCapture MediaCapture;
}
