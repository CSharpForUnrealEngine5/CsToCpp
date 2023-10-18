namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoBaseVec2ParameterSource is an implementation of IGizmoVec2ParameterSource</summary>
[CppInclude("BaseGizmos/ParameterSourcesVec2.h")]
public partial class UGizmoLocalVec2ParameterSource : UGizmoBaseVec2ParameterSource {
	public static UClass StaticClass() {return default;}
	///<summary>Value</summary>
	public FVector2D Value;
	///<summary>LastChange</summary>
	public FGizmoVec2ParameterChange LastChange;
}
