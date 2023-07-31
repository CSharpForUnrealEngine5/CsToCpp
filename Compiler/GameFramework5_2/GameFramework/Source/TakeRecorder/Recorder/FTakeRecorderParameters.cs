#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure housing all configurable parameters for a take recorder instance</summary>
[CppInclude("Recorder/TakeRecorderParameters.h")]
public partial struct FTakeRecorderParameters {
	public FTakeRecorderUserParameters User;
	public FTakeRecorderProjectParameters Project;
	public ETakeRecorderMode TakeRecorderMode;
	public FFrameNumber StartFrame;
	public bool bDisableRecordingAndSave;
}
