namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoFloatParameterSource : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>@return value of parameter</summary>
	public virtual float GetParameter() { return default; }
	///<summary>notify ParameterSource that a parameter modification is about to begin</summary>
	public virtual void BeginModify() {}
	///<summary>set value of parameter</summary>
	public virtual void SetParameter(float NewValue) {}
	///<summary>notify ParameterSource that a parameter modification is complete</summary>
	public virtual void EndModify() {}
}
