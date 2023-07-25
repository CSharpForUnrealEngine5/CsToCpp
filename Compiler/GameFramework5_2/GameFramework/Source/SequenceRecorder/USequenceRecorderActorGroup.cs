#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequenceRecorderActorGroup.h")]
public partial class USequenceRecorderActorGroup : UObject {
// SequenceRecorderActorGroup
	public string GroupName;
	public string SequenceName;
	public FDirectoryPath SequenceRecordingBasePath;
	public bool bSpecifyTargetLevelSequence;
	public ULevelSequence TargetLevelSequence;
	public bool bDuplicateTargetLevelSequence;
	public bool bRecordTargetLevelSequenceLength;
	public TArray<UActorRecording> RecordedActors;
}
