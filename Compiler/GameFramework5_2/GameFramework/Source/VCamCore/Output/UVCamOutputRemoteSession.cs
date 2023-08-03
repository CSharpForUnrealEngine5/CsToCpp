#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Output/VCamOutputRemoteSession.h")]
public partial class UVCamOutputRemoteSession : UVCamOutputProviderBase {
	public static UClass StaticClass() {return default;}
	///<summary>Network port number - change this only if connecting multiple RemoteSession devices to the same PC</summary>
	public int PortNumber;
	///<summary>If using the output from a Composure Output Provider, specify it here</summary>
	public int FromComposureOutputProviderIndex;
	///<summary>MediaOutput</summary>
	public URemoteSessionMediaOutput MediaOutput;
	///<summary>MediaCapture</summary>
	public URemoteSessionMediaCapture MediaCapture;
}
