namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/TakeRecorderParameters.h")]
public partial struct FTakeRecorderProjectParameters {
	public FDirectoryPath RootTakeSaveDir;
	public string TakeSaveDir;
	public string DefaultSlate;
	public EUpdateClockSource RecordingClockSource;
	public bool bStartAtCurrentTimecode;
	public bool bRecordTimecode;
	public bool bRecordSourcesIntoSubSequences;
	public bool bRecordToPossessable;
	public TArray<FTakeRecorderTrackSettings> DefaultTracks;
	public bool bShowNotifications;
}
