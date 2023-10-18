namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of vector curves.</summary>
[CppInclude("NiagaraDataInterfaceVector4Curve.h")]
public partial class UNiagaraDataInterfaceVector4Curve : UNiagaraDataInterfaceCurveBase {
	public static UClass StaticClass() {return default;}
	///<summary>XCurve</summary>
	public FRichCurve XCurve;
	///<summary>YCurve</summary>
	public FRichCurve YCurve;
	///<summary>ZCurve</summary>
	public FRichCurve ZCurve;
	///<summary>WCurve</summary>
	public FRichCurve WCurve;
	///<summary>XCurveCookedEditorCache</summary>
	public FRichCurve XCurveCookedEditorCache;
	///<summary>YCurveCookedEditorCache</summary>
	public FRichCurve YCurveCookedEditorCache;
	///<summary>ZCurveCookedEditorCache</summary>
	public FRichCurve ZCurveCookedEditorCache;
	///<summary>WCurveCookedEditorCache</summary>
	public FRichCurve WCurveCookedEditorCache;
}
