namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of float curves.</summary>
[CppInclude("NiagaraDataInterfaceCurve.h")]
public partial class UNiagaraDataInterfaceCurve : UNiagaraDataInterfaceCurveBase {
	public static UClass StaticClass() {return default;}
	///<summary>Curve</summary>
	public FRichCurve Curve;
	///<summary>CurveCookedEditorCache</summary>
	public FRichCurve CurveCookedEditorCache;
}
