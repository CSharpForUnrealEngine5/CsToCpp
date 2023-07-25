#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraActor.h")]
public partial class ANiagaraActor : AActor {
// NiagaraActor
	public void SetDestroyOnSystemFinish(bool bShouldDestroyOnSystemFinish) {}
	public UNiagaraComponent NiagaraComponent;
	public UBillboardComponent SpriteComponent;
	public UArrowComponent ArrowComponent;
	public bool bDestroyOnSystemFinish;
	public void OnNiagaraSystemFinished(UObject FinishedComponent) {}
}
