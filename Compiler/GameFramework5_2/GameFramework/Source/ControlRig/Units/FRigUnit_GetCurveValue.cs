#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>GetCurveValue is used to retrieve a single float from a Curve</summary>
[CppInclude("Units/Hierarchy/RigUnit_GetCurveValue.h")]
public partial struct FRigUnit_GetCurveValue {
	public string Curve;
	public bool Valid;
	public float Value;
	public FCachedRigElement CachedCurveIndex;
}
