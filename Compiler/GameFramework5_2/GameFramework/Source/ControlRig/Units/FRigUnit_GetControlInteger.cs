namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetControlFloat is used to retrieve a single Integer from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetControlTransform.h")]
public partial struct FRigUnit_GetControlInteger {
	public FName Control;
	public int IntegerValue;
	public int Minimum;
	public int Maximum;
	public FCachedRigElement CachedControlIndex;
}
