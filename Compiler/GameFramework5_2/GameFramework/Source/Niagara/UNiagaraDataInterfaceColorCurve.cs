#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceColorCurve.h")]
///<summary>Data Interface allowing sampling of color curves.</summary>
public partial class UNiagaraDataInterfaceColorCurve : UNiagaraDataInterfaceCurveBase {
// NiagaraDataInterfaceColorCurve
	public FRichCurve RedCurve;
	public FRichCurve GreenCurve;
	public FRichCurve BlueCurve;
	public FRichCurve AlphaCurve;
	public FRichCurve RedCurveCookedEditorCache;
	public FRichCurve GreenCurveCookedEditorCache;
	public FRichCurve BlueCurveCookedEditorCache;
	public FRichCurve AlphaCurveCookedEditorCache;
}
