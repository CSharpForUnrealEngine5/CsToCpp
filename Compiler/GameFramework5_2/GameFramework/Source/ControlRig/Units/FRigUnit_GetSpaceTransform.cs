namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetSpaceTransform is used to retrieve a single transform from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetSpaceTransform.h")]
public partial struct FRigUnit_GetSpaceTransform {
	public FName Space;
	public ERigVMTransformSpace SpaceType;
	public FTransform Transform;
	public FCachedRigElement CachedSpaceIndex;
}
