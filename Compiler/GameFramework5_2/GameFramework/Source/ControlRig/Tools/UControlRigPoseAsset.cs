#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/ControlRigPose.h")]
///<summary>An individual Pose made of Control Rig Controls</summary>
public partial class UControlRigPoseAsset : UObject {
// ControlRigPoseAsset
	public  void SavePose(UControlRig InControlRig,bool bUseAll) {}
	public  void PastePose(UControlRig InControlRig,bool bDoKey/*=false*/,bool bDoMirror/*=false*/) {}
	public  void SelectControls(UControlRig InControlRig,bool bDoMirror/*=false*/) {}
	public  void GetCurrentPose(UControlRig InControlRig,FControlRigControlPose OutPose) {}
	public  TArray<string> GetControlNames() { return default; }
	public  void ReplaceControlName(string CurrentName,string NewName) {}
	public  bool DoesMirrorMatch(UControlRig ControlRig,string ControlName) { return default; }
	public FControlRigControlPose Pose;
}
