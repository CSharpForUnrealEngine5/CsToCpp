namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data asset representing an array of records.</summary>
[CppInclude("LearningAgentsRecording.h")]
public partial class ULearningAgentsRecording : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Load this recording from a file.</summary>
	public void LoadRecordingFromFile(FFilePath File) {}
	///<summary>Save this recording to a file.</summary>
	public void SaveRecordingToFile(FFilePath File) {}
	///<summary>Append to this recording from a file.</summary>
	public void AppendRecordingFromFile(FFilePath File) {}
	///<summary>Loads this recording from the given recording asset</summary>
	public void LoadRecordingFromAsset(ULearningAgentsRecording RecordingAsset) {}
	///<summary>Saves this recording to the given recording asset</summary>
	public void SaveRecordingToAsset(ULearningAgentsRecording RecordingAsset) {}
	///<summary>Appends this recording to the given recording asset</summary>
	public void AppendRecordingToAsset(ULearningAgentsRecording RecordingAsset) {}
	///<summary>Set of records.</summary>
	public TArray<FLearningAgentsRecord> Records;
}
