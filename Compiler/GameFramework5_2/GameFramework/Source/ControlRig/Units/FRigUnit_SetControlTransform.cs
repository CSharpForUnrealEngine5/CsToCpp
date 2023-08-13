namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetControlTransform is used to perform a change in the hierarchy by setting a single control&#39;s transform.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
public partial struct FRigUnit_SetControlTransform {
	public string Control;
	public float Weight;
	public FTransform Transform;
	public ERigVMTransformSpace Space;
	public FCachedRigElement CachedControlIndex;
}
