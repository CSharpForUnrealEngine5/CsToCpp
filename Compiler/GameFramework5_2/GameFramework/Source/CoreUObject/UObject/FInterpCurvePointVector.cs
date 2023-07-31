#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes one specific point on an interpolation curve.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FInterpCurvePointVector {
	public float InVal;
	public FVector OutVal;
	public FVector ArriveTangent;
	public FVector LeaveTangent;
	public EInterpCurveMode InterpMode;
}
