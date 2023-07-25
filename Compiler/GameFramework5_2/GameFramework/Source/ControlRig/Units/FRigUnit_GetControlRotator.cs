#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_GetControlTransform.h")]
///<summary>GetControlRotator is used to retrieve a single Rotator from a hierarchy.</summary>
public partial struct FRigUnit_GetControlRotator {
// RigUnit_GetControlRotator
	public string Control;
	public ERigVMTransformSpace Space;
	public FRotator Rotator;
	public FRotator Minimum;
	public FRotator Maximum;
	public FCachedRigElement CachedControlIndex;
}
