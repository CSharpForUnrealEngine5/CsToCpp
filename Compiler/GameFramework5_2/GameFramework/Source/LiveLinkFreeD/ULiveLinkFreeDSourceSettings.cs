namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkFreeDSourceSettings.h")]
public partial class ULiveLinkFreeDSourceSettings : ULiveLinkSourceSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Send extra string meta data (Camera ID and FrameCounter)</summary>
	public bool bSendExtraMetaData;
	///<summary>Default configurations for specific manufacturers</summary>
	public EFreeDDefaultConfigs DefaultConfig;
	///<summary>Raw focus distance (in cm) encoder parameters for this camera - 24 bits max</summary>
	public FFreeDEncoderData FocusDistanceEncoderData;
	///<summary>Raw focal length/zoom (in mm) encoder parameters for this camera - 24 bits max</summary>
	public FFreeDEncoderData FocalLengthEncoderData;
	///<summary>Raw user defined/spare data encoder (normally used for Aperture) parameters for this camera - 16 bits max</summary>
	public FFreeDEncoderData UserDefinedEncoderData;
}
