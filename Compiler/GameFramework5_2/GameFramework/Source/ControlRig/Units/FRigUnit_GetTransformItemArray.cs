namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetTransformArray is used to retrieve an array of transforms from the hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetTransform.h")]
public partial struct FRigUnit_GetTransformItemArray {
	public TArray<FRigElementKey> Items;
	public ERigVMTransformSpace Space;
	public bool bInitial;
	public TArray<FTransform> Transforms;
	public TArray<FCachedRigElement> CachedIndex;
}
