#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceExport.h")]
public partial class UNiagaraParticleCallbackHandler : UInterface {
	///<summary>This function is called once per tick with the gathered particle data. It will not be called if there is no particle data to call it with.</summary>
	public  void ReceiveParticleData(TArray<FBasicParticleData> Data,UNiagaraSystem NiagaraSystem,FVector SimulationPositionOffset) {}
}
