#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraPerfBaseline.h")]
///<summary>Simple controller that will just spawn the given system N times. If any instance completes, it will spawn a new one to replace it.</summary>
public partial class UNiagaraBaselineController_Basic : UNiagaraBaselineController {
// NiagaraBaselineController_Basic
	public int NumInstances;
	public TArray<UNiagaraComponent> SpawnedComponents;
}
