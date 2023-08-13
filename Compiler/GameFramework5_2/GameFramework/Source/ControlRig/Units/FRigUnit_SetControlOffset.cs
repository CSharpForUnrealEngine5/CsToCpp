namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetControlOffset is used to perform a change in the hierarchy by setting a single control&#39;s transform.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlOffset.h")]
public partial struct FRigUnit_SetControlOffset {
	public string Control;
	public FTransform Offset;
	public ERigVMTransformSpace Space;
	public FCachedRigElement CachedControlIndex;
}
