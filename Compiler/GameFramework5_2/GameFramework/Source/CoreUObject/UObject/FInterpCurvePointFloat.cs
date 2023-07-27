#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Describes one specific point on an interpolation curve.</summary>
public partial struct FInterpCurvePointFloat {
// InterpCurvePointFloat
	public float InVal;
	public float OutVal;
	public float ArriveTangent;
	public float LeaveTangent;
	public EInterpCurveMode InterpMode;
}
