#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CurveEditorCopyBuffer.h")]
public partial class UCurveEditorCopyBuffer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Curves</summary>
	public TArray<UCurveEditorCopyableCurveKeys> Curves;
	///<summary>TimeOffset</summary>
	public double TimeOffset;
	///<summary>bAbsolutePosition</summary>
	public bool bAbsolutePosition;
}
