#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraParameterDefinitionsSubscriber.h")]
public partial struct FParameterDefinitionsSubscription {
// ParameterDefinitionsSubscription
	public UNiagaraParameterDefinitionsBase Definitions;
	public FGuid DefinitionsId_DEPRECATED;
	public int CachedChangeIdHash;
}
