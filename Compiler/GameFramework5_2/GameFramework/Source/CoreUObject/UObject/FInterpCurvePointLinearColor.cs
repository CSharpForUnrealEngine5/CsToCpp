#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Describes one specific point on an interpolation curve.</summary>
public partial struct FInterpCurvePointLinearColor {
// InterpCurvePointLinearColor
	public float InVal;
	public FLinearColor OutVal;
	public FLinearColor ArriveTangent;
	public FLinearColor LeaveTangent;
	public EInterpCurveMode InterpMode;
}
