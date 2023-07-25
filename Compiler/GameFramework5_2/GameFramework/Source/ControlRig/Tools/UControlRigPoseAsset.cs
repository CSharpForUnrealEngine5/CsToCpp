#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/ControlRigPose.h")]
///<summary>An individual Pose made of Control Rig Controls</summary>
public partial class UControlRigPoseAsset : UObject {
// ControlRigPoseAsset
	public void SavePose(UObject InControlRig,bool bUseAll) {}
	public void PastePose(UObject InControlRig,bool bDoKey/*=false*/,bool bDoMirror/*=false*/) {}
	public void SelectControls(UObject InControlRig,bool bDoMirror/*=false*/) {}
	public void GetCurrentPose(UObject InControlRig,FControlRigControlPose OutPose) {}
	public TArray<string> GetControlNames() { return default; }
	public void ReplaceControlName(string CurrentName,string NewName) {}
	public bool DoesMirrorMatch(UObject ControlRig,string ControlName) { return default; }
	public FControlRigControlPose Pose;
}
