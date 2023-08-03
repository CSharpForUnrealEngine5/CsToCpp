#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple controller that will just spawn the given system N times. If any instance completes, it will spawn a new one to replace it.</summary>
[CppInclude("NiagaraPerfBaseline.h")]
public partial class UNiagaraBaselineController_Basic : UNiagaraBaselineController {
	public static UClass StaticClass() {return default;}
	///<summary>NumInstances</summary>
	public int NumInstances;
	///<summary>SpawnedComponents</summary>
	public TArray<UNiagaraComponent> SpawnedComponents;
}
