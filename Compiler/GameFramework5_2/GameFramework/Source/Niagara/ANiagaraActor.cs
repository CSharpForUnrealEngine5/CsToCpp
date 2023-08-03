#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraActor.h")]
public partial class ANiagaraActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Set true for this actor to self-destruct when the Niagara system finishes, false otherwise</summary>
	public  void SetDestroyOnSystemFinish(bool bShouldDestroyOnSystemFinish) {}
	///<summary>Pointer to System component</summary>
	public UNiagaraComponent NiagaraComponent;
	///<summary>Reference to sprite visualization component</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>Reference to arrow visualization component</summary>
	public UArrowComponent ArrowComponent;
	///<summary>True for this actor to self-destruct when the Niagara system finishes, false otherwise</summary>
	public bool bDestroyOnSystemFinish;
	///<summary>Callback when Niagara system finishes.</summary>
	public  void OnNiagaraSystemFinished(UNiagaraComponent FinishedComponent) {}
}
