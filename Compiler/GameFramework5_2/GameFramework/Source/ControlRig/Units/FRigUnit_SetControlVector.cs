namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetControlVector is used to perform a change in the hierarchy by setting a single control&#39;s Vector value.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetControlTransform.h")]
public partial struct FRigUnit_SetControlVector {
	public string Control;
	public float Weight;
	public FVector Vector;
	public ERigVMTransformSpace Space;
	public FCachedRigElement CachedControlIndex;
}
