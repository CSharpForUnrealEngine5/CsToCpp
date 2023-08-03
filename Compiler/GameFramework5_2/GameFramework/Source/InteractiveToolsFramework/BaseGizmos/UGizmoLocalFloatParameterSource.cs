#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoLocalFloatParameterSource is an implementation of IGizmoFloatParameterSource</summary>
[CppInclude("BaseGizmos/ParameterSourcesFloat.h")]
public partial class UGizmoLocalFloatParameterSource : UGizmoBaseFloatParameterSource {
	public static UClass StaticClass() {return default;}
	///<summary>Value</summary>
	public float Value;
	///<summary>LastChange</summary>
	public FGizmoFloatParameterChange LastChange;
}
