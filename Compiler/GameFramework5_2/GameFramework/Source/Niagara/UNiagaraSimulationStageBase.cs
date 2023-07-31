#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A base class for niagara simulation stages.  This class should be derived to add stage specific information.</summary>
[CppInclude("NiagaraSimulationStageBase.h")]
public partial class UNiagaraSimulationStageBase : UNiagaraMergeable {
	///<summary>Script</summary>
	public UNiagaraScript Script;
	///<summary>SimulationStageName</summary>
	public string SimulationStageName;
	///<summary>bEnabled</summary>
	public bool bEnabled;
	///<summary>OuterEmitterVersion</summary>
	public FGuid OuterEmitterVersion;
}
