#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Deprecated/RigUnit_GetJointTransform.h")]
public partial struct FRigUnit_GetJointTransform {
// RigUnit_GetJointTransform
	public string Joint;
	public ETransformGetterType Type;
	public ETransformSpaceMode TransformSpace;
	public FTransform BaseTransform;
	public string BaseJoint;
	public FTransform Output;
}
