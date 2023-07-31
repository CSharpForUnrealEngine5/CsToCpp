#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/CurveSourceInterface.h")]
public partial class UCurveSourceInterface : UInterface {
	///<summary>Get the name that this curve source can be bound to by.</summary>
	public  string GetBindingName() { return default; }
	///<summary>Get the value for a specified curve</summary>
	public  float GetCurveValue(string CurveName) { return default; }
	///<summary>Evaluate all curves that this source provides</summary>
	public  void GetCurves(TArray<FNamedCurveValue> OutValues) {}
}
