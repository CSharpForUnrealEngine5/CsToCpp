#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineOutputSetting.h")]
public partial class UMoviePipelineOutputSetting : UMoviePipelineSetting {
// MoviePipelineOutputSetting
	public FDirectoryPath OutputDirectory;
	public string FileNameFormat;
	public FIntPoint OutputResolution;
	public bool bUseCustomFrameRate;
	public FFrameRate OutputFrameRate;
	public bool bOverrideExistingOutput;
	public int HandleFrameCount;
	public int OutputFrameStep;
	public bool bUseCustomPlaybackRange;
	public int CustomStartFrame;
	public int CustomEndFrame;
	public int VersionNumber;
	public bool bAutoVersion;
	public int ZeroPadFrameNumbers;
	public int FrameNumberOffset;
	public bool bFlushDiskWritesPerShot;
}
