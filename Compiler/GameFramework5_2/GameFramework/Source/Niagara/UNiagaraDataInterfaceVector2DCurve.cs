#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of vector curves.</summary>
[CppInclude("NiagaraDataInterfaceVector2DCurve.h")]
public partial class UNiagaraDataInterfaceVector2DCurve : UNiagaraDataInterfaceCurveBase {
	public static UClass StaticClass() {return default;}
	///<summary>XCurve</summary>
	public FRichCurve XCurve;
	///<summary>YCurve</summary>
	public FRichCurve YCurve;
	///<summary>XCurveCookedEditorCache</summary>
	public FRichCurve XCurveCookedEditorCache;
	///<summary>YCurveCookedEditorCache</summary>
	public FRichCurve YCurveCookedEditorCache;
}
