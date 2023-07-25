#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraPreviewGrid.h")]
///<summary>Base class for all preview axis types.</summary>
public partial class UNiagaraPreviewAxis : UObject {
// NiagaraPreviewAxis
	public int Num() { return default; }
	public void ApplyToPreview(UObject PreviewComponent,int PreviewIndex,bool bIsXAxis,string OutLabelText) {}
}
