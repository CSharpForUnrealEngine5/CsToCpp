#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderDocPluginSettings.h")]
public partial class URenderDocPluginSettings : UDeveloperSettings {
	///<summary>If checked, RenderDoc will capture all activity in all viewports and editor windows for the entire frame instead of only the current viewport.</summary>
	public bool bCaptureAllActivity;
	///<summary>If checked, RenderDoc will capture callstacks for all API calls.</summary>
	public bool bCaptureAllCallstacks;
	///<summary>If checked, RenderDoc will include all rendering resources in the capture, even those that have not been used during the frame. Please note that doing this will significantly increase capture size.</summary>
	public bool bReferenceAllResources;
	///<summary>If checked, RenderDoc will always capture the initial state of all rendering resources even if they are not likely to be used during the frame. Please note that doing this will significantly increase capture size.</summary>
	public bool bSaveAllInitials;
	///<summary>If checked, the capture delay&#39;s unit will be in seconds instead of frames.</summary>
	public bool bCaptureDelayInSeconds;
	///<summary>If &gt; 0, RenderDoc will trigger the capture only after this amount of frames/seconds has passed.</summary>
	public int CaptureDelay;
	///<summary>If &gt; 1, the RenderDoc capture will encompass more than a single frame. Note: this implies that all activity in all viewports and editor windows will be captured (i.e. same as CaptureAllActivity)</summary>
	public int CaptureFrameCount;
	///<summary>If checked, then RenderDoc will attach on startup. Otherwise the command line argument &#39;-AttachRenderDoc&#39; is required.</summary>
	public bool bAutoAttach;
	///<summary>If checked, a help window will be shown on startup.</summary>
	public bool bShowHelpOnStartup;
	///<summary>If checked, the RenderDoc crash handler will be used if a crash occurs (Only use this if you know the problem is with RenderDoc and you want to notify the RenderDoc developers!).</summary>
	public bool bEnableRenderDocCrashHandler;
	///<summary>Path to the main RenderDoc executable to use.</summary>
	public string RenderDocBinaryPath;
}
