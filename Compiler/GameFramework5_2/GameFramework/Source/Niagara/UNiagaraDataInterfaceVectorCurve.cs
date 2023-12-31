namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of vector curves.</summary>
[CppInclude("NiagaraDataInterfaceVectorCurve.h")]
public partial class UNiagaraDataInterfaceVectorCurve : UNiagaraDataInterfaceCurveBase {
	public static UClass StaticClass() {return default;}
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
