#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundWaveTimecodeInfo.h")]
public partial struct FSoundWaveTimecodeInfo {
	public ulong NumSamplesSinceMidnight;
	public uint NumSamplesPerSecond;
	public string Description;
	public string OriginatorTime;
	public string OriginatorDate;
	public string OriginatorDescription;
	public string OriginatorReference;
	public FFrameRate TimecodeRate;
	public bool bTimecodeIsDropFrame;
}
