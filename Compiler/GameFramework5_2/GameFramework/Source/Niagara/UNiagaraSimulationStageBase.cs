namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A base class for niagara simulation stages.  This class should be derived to add stage specific information.</summary>
[CppInclude("NiagaraSimulationStageBase.h")]
public partial class UNiagaraSimulationStageBase : UNiagaraMergeable {
	public static UClass StaticClass() {return default;}
	///<summary>Script</summary>
	public UNiagaraScript Script;
	///<summary>SimulationStageName</summary>
	public FName SimulationStageName;
	///<summary>bEnabled</summary>
	public bool bEnabled;
	///<summary>OuterEmitterVersion</summary>
	public FGuid OuterEmitterVersion;
}
