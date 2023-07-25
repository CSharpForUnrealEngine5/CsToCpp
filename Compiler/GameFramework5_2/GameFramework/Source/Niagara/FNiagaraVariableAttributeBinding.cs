#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraVariableAttributeBinding {
// NiagaraVariableAttributeBinding
	public FNiagaraVariableBase ParamMapVariable;
	public FNiagaraVariable DataSetVariable;
	public FNiagaraVariable RootVariable;
	public FNiagaraVariable BoundVariable;
	public string CachedDisplayName;
	public byte BindingSourceMode;
	public bool bBindingExistsOnSource;
	public bool bIsCachedParticleValue;
}
