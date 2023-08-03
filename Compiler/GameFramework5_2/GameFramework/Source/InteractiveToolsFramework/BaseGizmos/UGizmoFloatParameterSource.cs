#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoFloatParameterSource : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>@return value of parameter</summary>
	public  float GetParameter() { return default; }
	///<summary>notify ParameterSource that a parameter modification is about to begin</summary>
	public  void BeginModify() {}
	///<summary>set value of parameter</summary>
	public  void SetParameter(float NewValue) {}
	///<summary>notify ParameterSource that a parameter modification is complete</summary>
	public  void EndModify() {}
}
