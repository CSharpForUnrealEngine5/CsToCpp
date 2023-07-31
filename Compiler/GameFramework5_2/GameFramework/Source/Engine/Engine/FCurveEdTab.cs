#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/InterpCurveEdSetup.h")]
public partial struct FCurveEdTab {
	public string TabName;
	public TArray<FCurveEdEntry> Curves;
	public float ViewStartInput;
	public float ViewEndInput;
	public float ViewStartOutput;
	public float ViewEndOutput;
}
