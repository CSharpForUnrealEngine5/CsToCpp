#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Recorder/TakeRecorderParameters.h")]
///<summary>Structure housing all configurable parameters for a take recorder instance</summary>
public partial struct FTakeRecorderParameters {
// TakeRecorderParameters
	public FTakeRecorderUserParameters User;
	public FTakeRecorderProjectParameters Project;
	public ETakeRecorderMode TakeRecorderMode;
	public FFrameNumber StartFrame;
	public bool bDisableRecordingAndSave;
}
