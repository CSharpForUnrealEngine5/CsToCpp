#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoVec2ParameterSource : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>@return value of parameter</summary>
	public  FVector2D GetParameter() { return default; }
	///<summary>notify ParameterSource that a parameter modification is about to begin</summary>
	public  void BeginModify() {}
	///<summary>set value of parameter</summary>
	public  void SetParameter(FVector2D NewValue) {}
	///<summary>notify ParameterSource that a parameter modification is complete</summary>
	public  void EndModify() {}
}
