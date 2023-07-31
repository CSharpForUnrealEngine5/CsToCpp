#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes one specific point on an interpolation curve.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FInterpCurvePointLinearColor {
	public float InVal;
	public FLinearColor OutVal;
	public FLinearColor ArriveTangent;
	public FLinearColor LeaveTangent;
	public EInterpCurveMode InterpMode;
}
