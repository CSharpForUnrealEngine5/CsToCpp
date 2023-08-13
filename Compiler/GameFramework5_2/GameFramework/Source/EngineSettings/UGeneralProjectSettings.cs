namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeneralProjectSettings.h")]
public partial class UGeneralProjectSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the company (author, provider) that created the project.</summary>
	public string CompanyName;
	///<summary>The Distinguished Name of the company (author, provider) that created the project, which is used by publishing tools on some platforms.</summary>
	public string CompanyDistinguishedName;
	///<summary>The project&#39;s copyright and/or trademark notices.</summary>
	public string CopyrightNotice;
	///<summary>The project&#39;s description text.</summary>
	public string Description;
	///<summary>The project&#39;s homepage URL.</summary>
	public string Homepage;
	///<summary>The project&#39;s licensing terms.</summary>
	public string LicensingTerms;
	///<summary>The project&#39;s privacy policy.</summary>
	public string PrivacyPolicy;
	///<summary>The project&#39;s unique identifier.</summary>
	public FGuid ProjectID;
	///<summary>The project&#39;s non-localized name.</summary>
	public string ProjectName;
	///<summary>The project&#39;s version number.</summary>
	public string ProjectVersion;
	///<summary>The project&#39;s support contact information.</summary>
	public string SupportContact;
	///<summary>The project&#39;s title as displayed on the window title bar (can include the tokens {GameName}, {PlatformArchitecture}, {BuildConfiguration} or {RHIName}, which will be replaced with the specified text)</summary>
	public FText ProjectDisplayedTitle;
	///<summary>Additional data to be displayed on the window title bar in non-shipping configurations (can include the tokens {GameName}, {PlatformArchitecture}, {BuildConfiguration} or {RHIName}, which will be replaced with the specified text)</summary>
	public FText ProjectDebugTitleInfo;
	///<summary>Should the game&#39;s window preserve its aspect ratio when resized by user.</summary>
	public bool bShouldWindowPreserveAspectRatio;
	///<summary>Should the game use a borderless Slate window instead of a window with system title bar and border</summary>
	public bool bUseBorderlessWindow;
	///<summary>Should the game attempt to start in VR, regardless of whether -vr was set on the commandline</summary>
	public bool bStartInVR;
	///<summary>Should the user be allowed to resize the window used by the game, when not using full screen</summary>
	public bool bAllowWindowResize;
	///<summary>Should a close button be shown for the game&#39;s window, when not using full screen</summary>
	public bool bAllowClose;
	///<summary>Should a maximize button be shown for the game&#39;s window, when not using full screen</summary>
	public bool bAllowMaximize;
	///<summary>Should a minimize button be shown for the game&#39;s window, when not using full screen</summary>
	public bool bAllowMinimize;
	///<summary>Determines the Eye offset of the virtual stereo device created when &quot; -emulatestereo&quot; command line arg is detected</summary>
	public float EyeOffsetForFakeStereoRenderingDevice;
	///<summary>Determines the Field Of View of the virtual stereo device created when &quot; -emulatestereo&quot; command line arg is detected</summary>
	public float FOVForFakeStereoRenderingDevice;
}
