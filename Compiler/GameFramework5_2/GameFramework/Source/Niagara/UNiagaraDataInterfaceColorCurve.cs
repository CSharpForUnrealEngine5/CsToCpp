namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of color curves.</summary>
[CppInclude("NiagaraDataInterfaceColorCurve.h")]
public partial class UNiagaraDataInterfaceColorCurve : UNiagaraDataInterfaceCurveBase {
	public static UClass StaticClass() {return default;}
	///<summary>RedCurve</summary>
	public FRichCurve RedCurve;
	///<summary>GreenCurve</summary>
	public FRichCurve GreenCurve;
	///<summary>BlueCurve</summary>
	public FRichCurve BlueCurve;
	///<summary>AlphaCurve</summary>
	public FRichCurve AlphaCurve;
	///<summary>RedCurveCookedEditorCache</summary>
	public FRichCurve RedCurveCookedEditorCache;
	///<summary>GreenCurveCookedEditorCache</summary>
	public FRichCurve GreenCurveCookedEditorCache;
	///<summary>BlueCurveCookedEditorCache</summary>
	public FRichCurve BlueCurveCookedEditorCache;
	///<summary>AlphaCurveCookedEditorCache</summary>
	public FRichCurve AlphaCurveCookedEditorCache;
}
