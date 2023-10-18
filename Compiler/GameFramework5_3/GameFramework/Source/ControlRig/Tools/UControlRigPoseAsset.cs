namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An individual Pose made of Control Rig Controls</summary>
[CppInclude("Tools/ControlRigPose.h")]
public partial class UControlRigPoseAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SavePose</summary>
	public void SavePose(UControlRig InControlRig,bool bUseAll) {}
	///<summary>PastePose</summary>
	public void PastePose(UControlRig InControlRig,bool bDoKey/*=false*/,bool bDoMirror/*=false*/) {}
	///<summary>SelectControls</summary>
	public void SelectControls(UControlRig InControlRig,bool bDoMirror/*=false*/) {}
	///<summary>GetCurrentPose</summary>
	public void GetCurrentPose(UControlRig InControlRig,FControlRigControlPose OutPose) {}
	///<summary>GetControlNames</summary>
	public TArray<FName> GetControlNames() { return default; }
	///<summary>ReplaceControlName</summary>
	public void ReplaceControlName(FName CurrentName,FName NewName) {}
	///<summary>DoesMirrorMatch</summary>
	public bool DoesMirrorMatch(UControlRig ControlRig,FName ControlName) { return default; }
	///<summary>Pose</summary>
	public FControlRigControlPose Pose;
}
