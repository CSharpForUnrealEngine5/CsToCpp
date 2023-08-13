namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetControlTransform is used to retrieve a single transform from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetControlTransform.h")]
public partial struct FRigUnit_GetControlTransform {
	public string Control;
	public ERigVMTransformSpace Space;
	public FTransform Transform;
	public FTransform Minimum;
	public FTransform Maximum;
	public FCachedRigElement CachedControlIndex;
}
