#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceVectorCurve.h")]
///<summary>Data Interface allowing sampling of vector curves.</summary>
public partial class UNiagaraDataInterfaceVectorCurve : UNiagaraDataInterfaceCurveBase {
// NiagaraDataInterfaceVectorCurve
	public FRichCurve XCurve;
	public FRichCurve YCurve;
	public FRichCurve ZCurve;
	public FRichCurve XCurveCookedEditorCache;
	public FRichCurve YCurveCookedEditorCache;
	public FRichCurve ZCurveCookedEditorCache;
}
