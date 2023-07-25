#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MediaPlayerRecording.h")]
public partial class UMediaPlayerRecording : USequenceRecordingBase {
// MediaPlayerRecording
	public FMediaPlayerRecordingSettings RecordingSettings;
	public TWeakObjectPtr<UMediaPlayer> MediaPlayerToRecord;
}
