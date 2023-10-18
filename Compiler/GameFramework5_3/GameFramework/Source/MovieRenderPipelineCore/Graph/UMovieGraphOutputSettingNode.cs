namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/Nodes/MovieGraphOutputSettingNode.h")]
public partial class UMovieGraphOutputSettingNode : UMovieGraphSettingNode {
	public static UClass StaticClass() {return default;}
	///<summary>bOverride_OutputDirectory</summary>
	public bool bOverride_OutputDirectory;
	///<summary>bOverride_FileNameFormat</summary>
	public bool bOverride_FileNameFormat;
	///<summary>bOverride_OutputResolution</summary>
	public bool bOverride_OutputResolution;
	///<summary>bOverride_OutputFrameRate</summary>
	public bool bOverride_OutputFrameRate;
	///<summary>bOverride_bOverwriteExistingOutput</summary>
	public bool bOverride_bOverwriteExistingOutput;
	///<summary>bOverride_ZeroPadFrameNumbers</summary>
	public bool bOverride_ZeroPadFrameNumbers;
	///<summary>bOverride_FrameNumberOffset</summary>
	public bool bOverride_FrameNumberOffset;
	///<summary>What directory should all of our output files be relative to.</summary>
	public FDirectoryPath OutputDirectory;
	///<summary>What format string should the final files use? Can include folder prefixes, and format string ({shot_name}, etc.)</summary>
	public string FileNameFormat;
	///<summary>What resolution should our output files be exported at?</summary>
	public FIntPoint OutputResolution;
	///<summary>What frame rate should the output files be exported at? This overrides the Display Rate of the target sequence. If not overwritten, uses the default Sequence Display Rate.</summary>
	public FFrameRate OutputFrameRate;
	///<summary>If true, output containers should attempt to override any existing files with the same name.</summary>
	public bool bOverwriteExistingOutput;
	///<summary>How many digits should all output frame numbers be padded to? MySequence_1.png -&gt; MySequence_0001.png. Useful for software that struggles to recognize frame ranges when non-padded.</summary>
	public int ZeroPadFrameNumbers;
	///<summary>How many frames should we offset the output frame number by? This is useful when using handle frames on Sequences that start at frame 0,</summary>
	public int FrameNumberOffset;
}
