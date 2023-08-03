#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MediaPlayerRecording.h")]
public partial class UMediaPlayerRecording : USequenceRecordingBase {
	public static UClass StaticClass() {return default;}
	///<summary>Whether this MediaPlayer is active and its event will be recorded when the &#39;Record&#39; button is pressed.</summary>
	public FMediaPlayerRecordingSettings RecordingSettings;
	///<summary>The MediaPlayer we want to record</summary>
	public TWeakObjectPtr<UMediaPlayer> MediaPlayerToRecord;
}
