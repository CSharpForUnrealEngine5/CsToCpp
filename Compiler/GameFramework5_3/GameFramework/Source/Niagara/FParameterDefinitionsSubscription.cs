namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraParameterDefinitionsSubscriber.h")]
public partial struct FParameterDefinitionsSubscription {
	public UNiagaraParameterDefinitionsBase Definitions;
	public FGuid DefinitionsId_DEPRECATED;
	public int CachedChangeIdHash;
}
