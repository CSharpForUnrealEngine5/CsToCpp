#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of vector curves.</summary>
[CppInclude("NiagaraDataInterfaceVectorCurve.h")]
public partial class UNiagaraDataInterfaceVectorCurve : UNiagaraDataInterfaceCurveBase {
	///<summary>XCurve</summary>
	public FRichCurve XCurve;
	///<summary>YCurve</summary>
	public FRichCurve YCurve;
	///<summary>ZCurve</summary>
	public FRichCurve ZCurve;
	///<summary>XCurveCookedEditorCache</summary>
	public FRichCurve XCurveCookedEditorCache;
	///<summary>YCurveCookedEditorCache</summary>
	public FRichCurve YCurveCookedEditorCache;
	///<summary>ZCurveCookedEditorCache</summary>
	public FRichCurve ZCurveCookedEditorCache;
}
