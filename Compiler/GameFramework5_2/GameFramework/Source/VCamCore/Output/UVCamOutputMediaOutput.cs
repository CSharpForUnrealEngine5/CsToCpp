#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Output/VCamOutputMediaOutput.h")]
public partial class UVCamOutputMediaOutput : UVCamOutputProviderBase {
	///<summary>Media Output configuration asset</summary>
	public UMediaOutput OutputConfig;
	///<summary>If using the output from a Composure Output Provider, specify it here</summary>
	public int FromComposureOutputProviderIndex;
	///<summary>MediaCapture</summary>
	public UMediaCapture MediaCapture;
}
