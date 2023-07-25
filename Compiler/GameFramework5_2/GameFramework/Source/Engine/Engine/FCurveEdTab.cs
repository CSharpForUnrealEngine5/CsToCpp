#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/InterpCurveEdSetup.h")]
public partial struct FCurveEdTab {
// CurveEdTab
	public string TabName;
	public TArray<FCurveEdEntry> Curves;
	public float ViewStartInput;
	public float ViewEndInput;
	public float ViewStartOutput;
	public float ViewEndOutput;
}
