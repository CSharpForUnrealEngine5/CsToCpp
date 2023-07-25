#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetCurveValue.h")]
///<summary>SetCurveValue is used to perform a change in the curve container by setting a single Curve value.</summary>
public partial struct FRigUnit_SetCurveValue {
// RigUnit_SetCurveValue
	public string Curve;
	public float Value;
	public FCachedRigElement CachedCurveIndex;
}
