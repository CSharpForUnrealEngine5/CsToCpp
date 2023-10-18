namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetControlRotator is used to retrieve a single Rotator from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetControlTransform.h")]
public partial struct FRigUnit_GetControlRotator {
	public FName Control;
	public ERigVMTransformSpace Space;
	public FRotator Rotator;
	public FRotator Minimum;
	public FRotator Maximum;
	public FCachedRigElement CachedControlIndex;
}
