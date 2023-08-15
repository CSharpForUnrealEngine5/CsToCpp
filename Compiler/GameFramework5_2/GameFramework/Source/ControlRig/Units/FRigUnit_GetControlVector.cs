namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetControlVector is used to retrieve a single Vector from a hierarchy, can be used for Controls of type &quot;Position&quot; or &quot;Scale&quot;.</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetControlTransform.h")]
public partial struct FRigUnit_GetControlVector {
	public FName Control;
	public ERigVMTransformSpace Space;
	public FVector Vector;
	public FVector Minimum;
	public FVector Maximum;
	public FCachedRigElement CachedControlIndex;
}
