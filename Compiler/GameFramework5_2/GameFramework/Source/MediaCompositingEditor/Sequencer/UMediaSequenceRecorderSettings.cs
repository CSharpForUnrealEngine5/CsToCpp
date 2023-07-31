#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MediaSequenceRecorderExtender.h")]
public partial class UMediaSequenceRecorderSettings : UObject {
	///<summary>Whether to enabled MediaPlayer recording into this sequence.</summary>
	public bool bRecordMediaPlayerEnabled;
	///<summary>The name of the subdirectory MediaPlayer will be placed in. Leave this empty to place into the same directory as the sequence base path</summary>
	public string MediaPlayerSubDirectory;
}
