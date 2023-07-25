#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceVector4Curve.h")]
///<summary>Data Interface allowing sampling of vector curves.</summary>
public partial class UNiagaraDataInterfaceVector4Curve : UNiagaraDataInterfaceCurveBase {
// NiagaraDataInterfaceVector4Curve
	public FRichCurve XCurve;
	public FRichCurve YCurve;
	public FRichCurve ZCurve;
	public FRichCurve WCurve;
	public FRichCurve XCurveCookedEditorCache;
	public FRichCurve YCurveCookedEditorCache;
	public FRichCurve ZCurveCookedEditorCache;
	public FRichCurve WCurveCookedEditorCache;
}
