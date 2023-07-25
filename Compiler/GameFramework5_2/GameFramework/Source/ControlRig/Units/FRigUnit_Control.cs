#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Control/RigUnit_Control.h")]
///<summary>A control unit used to drive a transform from an external source</summary>
public partial struct FRigUnit_Control {
// RigUnit_Control
	public FEulerTransform Transform;
	public FTransform Base;
	public FTransform InitTransform;
	public FTransform Result;
	public FTransformFilter Filter;
	public bool bIsInitialized;
}
