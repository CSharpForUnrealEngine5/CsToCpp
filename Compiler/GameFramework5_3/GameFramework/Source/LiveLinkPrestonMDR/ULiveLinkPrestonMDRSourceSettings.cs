namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkPrestonMDRSourceSettings.h")]
public partial class ULiveLinkPrestonMDRSourceSettings : ULiveLinkSourceSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The mode in which the Preston MDR is configured to send FIZ data (pre-calibrated or raw encoder positions)</summary>
	public EFIZDataMode IncomingDataMode;
	///<summary>Raw focus encoder range</summary>
	public FEncoderRange FocusEncoderRange;
	///<summary>Raw iris encoder range</summary>
	public FEncoderRange IrisEncoderRange;
	///<summary>Raw zoom encoder range</summary>
	public FEncoderRange ZoomEncoderRange;
}
