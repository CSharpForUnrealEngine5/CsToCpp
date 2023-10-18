namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetControlBool is used to retrieve a single Bool from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetControlTransform.h")]
public partial struct FRigUnit_GetControlBool {
	public FName Control;
	public bool BoolValue;
	public FCachedRigElement CachedControlIndex;
}
