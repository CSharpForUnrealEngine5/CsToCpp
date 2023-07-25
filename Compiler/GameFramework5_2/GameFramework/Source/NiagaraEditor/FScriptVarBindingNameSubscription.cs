#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraParameterDefinitions.h")]
///<summary>Helper structs to map between external parameter libraries and a set of their script variables to local script variables.</summary>
public partial struct FScriptVarBindingNameSubscription {
// ScriptVarBindingNameSubscription
	public FGuid ExternalScriptVarId;
	public TArray<FGuid> InternalScriptVarIds;
}
