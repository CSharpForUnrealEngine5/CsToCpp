#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimulationStageBase.h")]
///<summary>A base class for niagara simulation stages.  This class should be derived to add stage specific information.</summary>
public partial class UNiagaraSimulationStageBase : UNiagaraMergeable {
// NiagaraSimulationStageBase
	public UNiagaraScript Script;
	public string SimulationStageName;
	public bool bEnabled;
	public FGuid OuterEmitterVersion;
}
