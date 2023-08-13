namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraVariableAttributeBinding {
	public FNiagaraVariableBase ParamMapVariable;
	public FNiagaraVariable DataSetVariable;
	public FNiagaraVariable RootVariable;
	public FNiagaraVariable BoundVariable;
	public string CachedDisplayName;
	public ENiagaraBindingSource BindingSourceMode;
	public bool bBindingExistsOnSource;
	public bool bIsCachedParticleValue;
}
