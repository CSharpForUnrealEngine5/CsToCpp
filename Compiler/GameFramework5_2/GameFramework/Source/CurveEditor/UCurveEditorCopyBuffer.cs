#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CurveEditorCopyBuffer.h")]
public partial class UCurveEditorCopyBuffer : UObject {
// CurveEditorCopyBuffer
	public TArray<UCurveEditorCopyableCurveKeys> Curves;
	public double TimeOffset;
	public bool bAbsolutePosition;
}
