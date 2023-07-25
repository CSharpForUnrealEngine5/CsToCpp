#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_ModifyTransforms.h")]
///<summary>Modify Transforms is used to perform a change in the hierarchy by setting one or more bones' transforms</summary>
public partial struct FRigUnit_ModifyTransforms {
// RigUnit_ModifyTransforms
	public TArray<FRigUnit_ModifyTransforms_PerItem> ItemToModify;
	public float Weight;
	public float WeightMinimum;
	public float WeightMaximum;
	public EControlRigModifyBoneMode Mode;
	public FRigUnit_ModifyTransforms_WorkData WorkData;
}
