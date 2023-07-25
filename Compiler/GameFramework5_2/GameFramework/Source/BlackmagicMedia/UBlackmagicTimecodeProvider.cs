#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlackmagicTimecodeProvider.h")]
///<summary>Class to fetch a timecode via a Blackmagic Design card.</summary>
public partial class UBlackmagicTimecodeProvider : UGenlockedTimecodeProvider {
// BlackmagicTimecodeProvider
	public FMediaIOConfiguration MediaConfiguration_DEPRECATED;
	public EMediaIOTimecodeFormat TimecodeFormat_DEPRECATED;
	public FMediaIOVideoTimecodeConfiguration TimecodeConfiguration;
	public bool bAutoDetectTimecode;
}
