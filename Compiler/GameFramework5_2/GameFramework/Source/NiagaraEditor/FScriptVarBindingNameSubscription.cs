#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper structs to map between external parameter libraries and a set of their script variables to local script variables.</summary>
[CppInclude("NiagaraParameterDefinitions.h")]
public partial struct FScriptVarBindingNameSubscription {
	public FGuid ExternalScriptVarId;
	public TArray<FGuid> InternalScriptVarIds;
}
