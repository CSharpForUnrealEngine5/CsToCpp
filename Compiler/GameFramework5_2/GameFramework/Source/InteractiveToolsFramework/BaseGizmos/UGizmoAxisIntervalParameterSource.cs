namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoAxisIntervalParameterSource is an IGizmoFloatParameterSource implementation that</summary>
[CppInclude("BaseGizmos/IntervalGizmo.h")]
public partial class UGizmoAxisIntervalParameterSource : UGizmoBaseFloatParameterSource {
	public static UClass StaticClass() {return default;}
	///<summary>FloatParameterSource</summary>
	public object /*FloatParameterSource*/ FloatParameterSource;
	///<summary>MinParameter</summary>
	public float MinParameter;
	///<summary>MaxParameter</summary>
	public float MaxParameter;
}
