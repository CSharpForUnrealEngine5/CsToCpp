#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_GetControlTransform.h")]
///<summary>GetControlVector is used to retrieve a single Vector from a hierarchy, can be used for Controls of type "Position" or "Scale".</summary>
public partial struct FRigUnit_GetControlVector {
// RigUnit_GetControlVector
	public string Control;
	public ERigVMTransformSpace Space;
	public FVector Vector;
	public FVector Minimum;
	public FVector Maximum;
	public FCachedRigElement CachedControlIndex;
}
