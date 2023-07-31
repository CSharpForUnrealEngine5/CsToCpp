#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamPixelStreamingSession.h")]
public partial class UVCamPixelStreamingSession : UVCamOutputProviderBase {
	///<summary>If using the output from a Composure Output Provider, specify it here</summary>
	public int FromComposureOutputProviderIndex;
	///<summary>If true the streamed UE viewport will match the resolution of the remote device.</summary>
	public bool bMatchRemoteResolution;
	///<summary>Check this if you wish to control the corresponding CineCamera with transform data received from the LiveLink app</summary>
	public bool EnableARKitTracking;
	///<summary>If not selected, when the editor is not the foreground application, input through the vcam session may seem sluggish or unresponsive.</summary>
	public bool PreventEditorIdle;
	///<summary>If true then the Live Link Subject of the owning VCam Component will be set to the subject created by this Output Provider when the Provider is enabled</summary>
	public bool bAutoSetLiveLinkSubject;
	///<summary>Set the name of this stream to be reported to the signalling server. If none is supplied a default will be used. If ids are not unique issues can occur.</summary>
	public string StreamerId;
	///<summary>MediaOutput</summary>
	public UPixelStreamingMediaOutput MediaOutput;
	///<summary>MediaCapture</summary>
	public UPixelStreamingMediaCapture MediaCapture;
}
