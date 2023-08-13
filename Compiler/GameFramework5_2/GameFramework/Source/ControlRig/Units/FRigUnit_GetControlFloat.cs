namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetControlFloat is used to retrieve a single Float from a hierarchy.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetControlTransform.h")]
public partial struct FRigUnit_GetControlFloat {
	public string Control;
	public float FloatValue;
	public float Minimum;
	public float Maximum;
	public FCachedRigElement CachedControlIndex;
}
