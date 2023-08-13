namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all preview axis types.</summary>
[CppInclude("NiagaraPreviewGrid.h")]
public partial class UNiagaraPreviewAxis : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the number of previews for this axis.</summary>
	public int Num() { return default; }
	///<summary>Applies this axis for the preview at PreviewIndex on this axis.</summary>
	public void ApplyToPreview(UNiagaraComponent PreviewComponent,int PreviewIndex,bool bIsXAxis,string OutLabelText) {}
}
