namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about a particule curve being viewed.</summary>
[CppInclude("Engine/InterpCurveEdSetup.h")]
public partial struct FCurveEdEntry {
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
