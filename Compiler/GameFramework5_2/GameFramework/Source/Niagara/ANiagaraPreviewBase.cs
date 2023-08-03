#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base actor for preview actors used in UNiagaraPreviewAxis.</summary>
[CppInclude("NiagaraPreviewGrid.h")]
public partial class ANiagaraPreviewBase : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>AActor Interface End</summary>
	public  void SetSystem(UNiagaraSystem InSystem) {}
	///<summary>SetLabelText</summary>
	public  void SetLabelText(string InXAxisText,string InYAxisText) {}
}
