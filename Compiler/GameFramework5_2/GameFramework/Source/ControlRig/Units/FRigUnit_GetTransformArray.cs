#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_GetTransform.h")]
///<summary>GetTransformArray is used to retrieve an array of transforms from the hierarchy.</summary>
public partial struct FRigUnit_GetTransformArray {
// RigUnit_GetTransformArray
	public FRigElementKeyCollection Items;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public TArray<FTransform> Transforms;
	public TArray<FCachedRigElement> CachedIndex;
}
