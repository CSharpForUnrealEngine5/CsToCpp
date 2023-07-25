#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigTestData.h")]
public partial class UControlRigTestData : UObject {
// ControlRigTestData
	public UObject CreateNewAsset(string InDesiredPackagePath,string InBlueprintPathName) { return default; }
	public FVector2D GetTimeRange(bool bInput/*=false*/) { return default; }
	public int GetFrameIndexForTime(double InSeconds,bool bInput/*=false*/) { return default; }
	public bool Record(UObject InControlRig,double InRecordingDuration/*=0.0*/) { return default; }
	public bool SetupReplay(UObject InControlRig,bool bGroundTruth/*=true*/) { return default; }
	public void ReleaseReplay() {}
	public EControlRigTestDataPlaybackMode GetPlaybackMode() { return default; }
	public bool IsReplaying() { return default; }
	public bool IsRecording() { return default; }
	public FSoftObjectPath ControlRigObjectPath;
	public FControlRigTestDataFrame Initial;
	public TArray<FControlRigTestDataFrame> InputFrames;
	public TArray<FControlRigTestDataFrame> OutputFrames;
	public TArray<int> FramesToSkip;
	public double Tolerance;
}
