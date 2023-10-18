namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class to fetch a timecode via a Blackmagic Design card.</summary>
[CppInclude("BlackmagicTimecodeProvider.h")]
public partial class UBlackmagicTimecodeProvider : UGenlockedTimecodeProvider {
	public static UClass StaticClass() {return default;}
	///<summary>The device, port and video settings that correspond to the input.</summary>
	public FMediaIOConfiguration MediaConfiguration_DEPRECATED;
	///<summary>Timecode format to read from a video signal.</summary>
	public EMediaIOTimecodeFormat TimecodeFormat_DEPRECATED;
	///<summary>Timecode format to read from a video signal.</summary>
	public FMediaIOVideoTimecodeConfiguration TimecodeConfiguration;
	///<summary>bAutoDetectTimecode</summary>
	public bool bAutoDetectTimecode;
}
