#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_ModifyBoneTransforms.h")]
///<summary>ModifyBonetransforms is used to perform a change in the hierarchy by setting one or more bones' transforms.</summary>
public partial struct FRigUnit_ModifyBoneTransforms {
// RigUnit_ModifyBoneTransforms
	public TArray<FRigUnit_ModifyBoneTransforms_PerBone> BoneToModify;
	public float Weight;
	public float WeightMinimum;
	public float WeightMaximum;
	public EControlRigModifyBoneMode Mode;
	public FRigUnit_ModifyBoneTransforms_WorkData WorkData;
}
