namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequenceRecorderActorGroup.h")]
public partial class USequenceRecorderActorGroup : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GroupName</summary>
	public FName GroupName;
	///<summary>The base name of the sequence to record to. This name will also be used to auto-generate any assets created by this recording.</summary>
	public string SequenceName;
	///<summary>Base path for this recording. Sub-assets will be created in subdirectories as specified</summary>
	public FDirectoryPath SequenceRecordingBasePath;
	///<summary>Whether we should specify the target level sequence or auto-create it</summary>
	public bool bSpecifyTargetLevelSequence;
	///<summary>The level sequence to record into</summary>
	public ULevelSequence TargetLevelSequence;
	///<summary>Whether we should duplicate the target level sequence and record into the duplicate</summary>
	public bool bDuplicateTargetLevelSequence;
	///<summary>Whether we should record to the length of the target level sequence</summary>
	public bool bRecordTargetLevelSequenceLength;
	///<summary>A list of actor recordings in this group which contains both the actors to record as well as settings for each one.</summary>
	public TArray<UActorRecording> RecordedActors;
}
