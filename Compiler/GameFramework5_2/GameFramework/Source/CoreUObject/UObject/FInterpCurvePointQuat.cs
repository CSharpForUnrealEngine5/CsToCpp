#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Describes one specific point on an interpolation curve.</summary>
public partial struct FInterpCurvePointQuat {
// InterpCurvePointQuat
	public float InVal;
	public FQuat OutVal;
	public FQuat ArriveTangent;
	public FQuat LeaveTangent;
	public EInterpCurveMode InterpMode;
}
