namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class to fetch a timecode via an AJA card.</summary>
[CppInclude("AjaTimecodeProvider.h")]
public partial class UAjaTimecodeProvider : UGenlockedTimecodeProvider {
	public static UClass StaticClass() {return default;}
	///<summary>Should we read the timecode from a dedicated LTC pin or an SDI input.</summary>
	public bool bUseDedicatedPin;
	///<summary>Read LTC timecode from reference pin. Will fail if device doesn&#39;t support that feature.</summary>
	public bool bUseReferenceIn;
	///<summary>Where to read LTC timecode from with which FrameRate expected</summary>
	public FAjaMediaTimecodeReference LTCConfiguration;
	///<summary>It read the timecode from an input source.</summary>
	public FAjaMediaTimecodeConfiguration VideoConfiguration_DEPRECATED;
	///<summary>Timecode format to read from a video signal.</summary>
	public FMediaIOVideoTimecodeConfiguration TimecodeConfiguration;
	///<summary>bAutoDetectTimecode</summary>
	public bool bAutoDetectTimecode;
	///<summary>Engine used to initialize the Provider</summary>
	public UEngine InitializedEngine;
}
