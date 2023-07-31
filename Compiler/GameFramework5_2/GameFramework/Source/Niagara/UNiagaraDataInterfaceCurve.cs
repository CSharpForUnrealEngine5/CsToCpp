#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of float curves.</summary>
[CppInclude("NiagaraDataInterfaceCurve.h")]
public partial class UNiagaraDataInterfaceCurve : UNiagaraDataInterfaceCurveBase {
	///<summary>Curve</summary>
	public FRichCurve Curve;
	///<summary>CurveCookedEditorCache</summary>
	public FRichCurve CurveCookedEditorCache;
}
