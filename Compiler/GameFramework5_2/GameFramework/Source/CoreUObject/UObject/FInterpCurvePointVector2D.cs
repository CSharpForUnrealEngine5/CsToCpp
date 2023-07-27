#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Describes one specific point on an interpolation curve.</summary>
public partial struct FInterpCurvePointVector2D {
// InterpCurvePointVector2D
	public float InVal;
	public FVector2D OutVal;
	public FVector2D ArriveTangent;
	public FVector2D LeaveTangent;
	public EInterpCurveMode InterpMode;
}
