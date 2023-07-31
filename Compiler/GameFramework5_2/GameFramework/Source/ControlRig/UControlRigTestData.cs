#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigTestData.h")]
public partial class UControlRigTestData : UObject {
	///<summary>CreateNewAsset</summary>
	public static UControlRigTestData CreateNewAsset(string InDesiredPackagePath,string InBlueprintPathName) { return default; }
	///<summary>GetTimeRange</summary>
	public  FVector2D GetTimeRange(bool bInput/*=false*/) { return default; }
	///<summary>GetFrameIndexForTime</summary>
	public  int GetFrameIndexForTime(double InSeconds,bool bInput/*=false*/) { return default; }
	///<summary>Record</summary>
	public  bool Record(UControlRig InControlRig,double InRecordingDuration/*=0.0*/) { return default; }
	///<summary>SetupReplay</summary>
	public  bool SetupReplay(UControlRig InControlRig,bool bGroundTruth/*=true*/) { return default; }
	///<summary>ReleaseReplay</summary>
	public  void ReleaseReplay() {}
	///<summary>GetPlaybackMode</summary>
	public  EControlRigTestDataPlaybackMode GetPlaybackMode() { return default; }
	///<summary>IsReplaying</summary>
	public  bool IsReplaying() { return default; }
	///<summary>IsRecording</summary>
	public  bool IsRecording() { return default; }
	///<summary>ControlRigObjectPath</summary>
	public FSoftObjectPath ControlRigObjectPath;
	///<summary>Initial</summary>
	public FControlRigTestDataFrame Initial;
	///<summary>InputFrames</summary>
	public TArray<FControlRigTestDataFrame> InputFrames;
	///<summary>OutputFrames</summary>
	public TArray<FControlRigTestDataFrame> OutputFrames;
	///<summary>FramesToSkip</summary>
	public TArray<int> FramesToSkip;
	///<summary>Tolerance</summary>
	public double Tolerance;
}
