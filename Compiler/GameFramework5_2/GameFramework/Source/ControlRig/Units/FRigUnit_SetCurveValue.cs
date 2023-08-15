namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SetCurveValue is used to perform a change in the curve container by setting a single Curve value.</summary>
[CppInclude("Units/Hierarchy/RigUnit_SetCurveValue.h")]
public partial struct FRigUnit_SetCurveValue {
	public FName Curve;
	public float Value;
	public FCachedRigElement CachedCurveIndex;
}
