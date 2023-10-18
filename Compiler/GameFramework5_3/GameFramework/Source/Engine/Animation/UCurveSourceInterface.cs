namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/CurveSourceInterface.h")]
public partial class UCurveSourceInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Get the name that this curve source can be bound to by.</summary>
	public FName GetBindingName() { return default; }
	///<summary>Get the value for a specified curve</summary>
	public float GetCurveValue(FName CurveName) { return default; }
	///<summary>Evaluate all curves that this source provides</summary>
	public void GetCurves(TArray<FNamedCurveValue> OutValues) {}
}
