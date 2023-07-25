#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_GetCurveValue.h")]
///<summary>GetCurveValue is used to retrieve a single float from a Curve</summary>
public partial struct FRigUnit_GetCurveValue {
// RigUnit_GetCurveValue
	public string Curve;
	public bool Valid;
	public float Value;
	public FCachedRigElement CachedCurveIndex;
}
