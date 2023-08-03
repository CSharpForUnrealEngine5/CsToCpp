#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineOutputSetting.h")]
public partial class UMoviePipelineOutputSetting : UMoviePipelineSetting {
	public static UClass StaticClass() {return default;}
	///<summary>What directory should all of our output files be relative to.</summary>
	public FDirectoryPath OutputDirectory;
	///<summary>What format string should the final files use? Can include folder prefixes, and format string ({shot_name}, etc.)</summary>
	public string FileNameFormat;
	///<summary>What resolution should our output files be exported at?</summary>
	public FIntPoint OutputResolution;
	///<summary>Should we use the custom frame rate specified by OutputFrameRate? Otherwise defaults to Sequence frame rate.</summary>
	public bool bUseCustomFrameRate;
	///<summary>What frame rate should the output files be exported at? This overrides the Display Rate of the target sequence.</summary>
	public FFrameRate OutputFrameRate;
	///<summary>If true, output containers should attempt to override any existing files with the same name.</summary>
	public bool bOverrideExistingOutput;
	///<summary>Top level shot track sections will automatically be expanded by this many frames in both directions, and the resulting</summary>
	public int HandleFrameCount;
	///<summary>Render every Nth frame. ie: Setting this value to 2 renders every other frame. Game Thread is still evaluated on &#39;skipped&#39; frames for accuracy between renders of different OutputFrameSteps.</summary>
	public int OutputFrameStep;
	///<summary>If true, override the Playback Range start/end bounds with the bounds specified below.</summary>
	public bool bUseCustomPlaybackRange;
	///<summary>Used when overriding the playback range. In Display Rate frames. If bUseCustomPlaybackRange is false range will come from Sequence.</summary>
	public int CustomStartFrame;
	///<summary>Used when overriding the playback range. In Display Rate frames. If bUseCustomPlaybackRange is false range will come from Sequence.</summary>
	public int CustomEndFrame;
	///<summary>The value to use for the version token if versions are not automatically incremented.</summary>
	public int VersionNumber;
	///<summary>If true, version tokens will automatically be incremented with each local render. If false, the custom version number below will be used.</summary>
	public bool bAutoVersion;
	///<summary>How many digits should all output frame numbers be padded to? MySequence_1.png -&gt; MySequence_0001.png. Useful for software that struggles to recognize frame ranges when non-padded.</summary>
	public int ZeroPadFrameNumbers;
	///<summary>How many frames should we offset the output frame number by? This is useful when using handle frames on Sequences that start at frame 0,</summary>
	public int FrameNumberOffset;
	///<summary>If true, the game thread will stall at the end of each shot to flush the rendering queue, and then flush any outstanding writes to disk, finalizing any</summary>
	public bool bFlushDiskWritesPerShot;
}
