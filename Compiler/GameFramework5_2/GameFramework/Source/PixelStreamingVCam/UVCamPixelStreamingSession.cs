#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamPixelStreamingSession.h")]
public partial class UVCamPixelStreamingSession : UVCamOutputProviderBase {
// VCamPixelStreamingSession
	public int FromComposureOutputProviderIndex;
	public bool bMatchRemoteResolution;
	public bool EnableARKitTracking;
	public bool PreventEditorIdle;
	public bool bAutoSetLiveLinkSubject;
	public string StreamerId;
	public UPixelStreamingMediaOutput MediaOutput;
	public UPixelStreamingMediaCapture MediaCapture;
}
