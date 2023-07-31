#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Animation node that allows animation ControlRig output to be used in an animation graph</summary>
[CppInclude("AnimNode_ControlRigBase.h")]
public partial struct FAnimNode_ControlRigBase {
	public FPoseLink Source;
	public bool bResetInputPoseToInitial;
	public bool bTransferInputPose;
	public bool bTransferInputCurves;
	public bool bTransferPoseInGlobalSpace;
	public TArray<FBoneReference> InputBonesToTransfer;
	public TWeakObjectPtr<UNodeMappingContainer> NodeMappingContainer;
	public FControlRigIOSettings InputSettings;
	public FControlRigIOSettings OutputSettings;
	public bool bExecute;
	public TArray<FControlRigAnimNodeEventName> EventQueue;
}
