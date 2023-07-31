#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraParameterDefinitionsSubscriber.h")]
public partial struct FParameterDefinitionsSubscription {
	public UNiagaraParameterDefinitionsBase Definitions;
	public FGuid DefinitionsId_DEPRECATED;
	public int CachedChangeIdHash;
}
