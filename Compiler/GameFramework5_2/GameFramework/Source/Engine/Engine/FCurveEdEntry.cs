#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/InterpCurveEdSetup.h")]
///<summary>Information about a particule curve being viewed.</summary>
public partial struct FCurveEdEntry {
// CurveEdEntry
	public UObject CurveObject;
	public FColor CurveColor;
	public string CurveName;
	public int bHideCurve;
	public int bColorCurve;
	public int bFloatingPointColorCurve;
	public int bClamp;
	public float ClampLow;
	public float ClampHigh;
}
