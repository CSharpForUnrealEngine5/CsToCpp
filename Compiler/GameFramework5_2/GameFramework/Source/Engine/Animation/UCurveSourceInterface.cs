#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/CurveSourceInterface.h")]
public partial class UCurveSourceInterface : UInterface {
// CurveSourceInterface
	public  string GetBindingName() { return default; }
	public  float GetCurveValue(string CurveName) { return default; }
	public  void GetCurves(TArray<FNamedCurveValue> OutValues) {}
}
