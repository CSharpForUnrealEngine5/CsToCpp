#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderDocPluginSettings.h")]
public partial class URenderDocPluginSettings : UDeveloperSettings {
// RenderDocPluginSettings
	public bool bCaptureAllActivity;
	public bool bCaptureAllCallstacks;
	public bool bReferenceAllResources;
	public bool bSaveAllInitials;
	public bool bCaptureDelayInSeconds;
	public int CaptureDelay;
	public int CaptureFrameCount;
	public bool bAutoAttach;
	public bool bShowHelpOnStartup;
	public bool bEnableRenderDocCrashHandler;
	public string RenderDocBinaryPath;
}
