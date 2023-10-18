namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that can be used to create recordings of training data for imitation learning.</summary>
[CppInclude("LearningAgentsRecorder.h")]
public partial class ULearningAgentsRecorder : ULearningAgentsManagerComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Initializes this object and runs the setup functions for the underlying data storage.</summary>
	public void SetupRecorder(ULearningAgentsInteractor InInteractor,FLearningAgentsRecorderPathSettings RecorderPathSettings/*=new FLearningAgentsRecorderPathSettings()*/,ULearningAgentsRecording RecordingAsset/*=nullptr*/) {}
	///<summary>Begins the recording of the observations and actions of each added agent.</summary>
	public void BeginRecording(bool bReinitializeRecording/*=true*/) {}
	///<summary>Ends the recording of the observations and actions of each agent and stores them in the current recording object.</summary>
	public void EndRecording() {}
	///<summary>Returns true if recording is active; Otherwise, false.</summary>
	public bool IsRecording() { return default; }
	///<summary>While recording, adds the current observations and actions of the added agents to the internal buffer. Call this</summary>
	public void AddExperience() {}
	///<summary>Gets the current recording object. Note: this may be empty until EndRecording has been called.</summary>
	public ULearningAgentsRecording GetCurrentRecording() { return default; }
	///<summary>Loads the current recording object from a file</summary>
	public void LoadRecordingFromFile(FFilePath File) {}
	///<summary>Saves the current recording object to a file</summary>
	public void SaveRecordingToFile(FFilePath File) {}
	///<summary>Append to the current recording object from a file.</summary>
	public void AppendRecordingFromFile(FFilePath File) {}
	///<summary>Uses the given recording asset. New recordings will be appended to this.</summary>
	public void UseRecordingAsset(ULearningAgentsRecording RecordingAsset) {}
	///<summary>Loads the current recording object from the given recording asset</summary>
	public void LoadRecordingFromAsset(ULearningAgentsRecording RecordingAsset) {}
	///<summary>Saves the current recording object to the given recording asset</summary>
	public void SaveRecordingToAsset(ULearningAgentsRecording RecordingAsset) {}
	///<summary>Appends the current recording object to the given recording asset</summary>
	public void AppendRecordingToAsset(ULearningAgentsRecording RecordingAsset) {}
	///<summary>The agent interactor this recorder is associated with.</summary>
	public ULearningAgentsInteractor Interactor;
	///<summary>The current recording object.</summary>
	public ULearningAgentsRecording Recording;
	///<summary>True if recording is currently in-progress. Otherwise, false.</summary>
	public bool bIsRecording;
}
