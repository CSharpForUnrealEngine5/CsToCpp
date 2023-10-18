namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraVariableAttributeBinding {
	public FNiagaraVariable RootVariable;
	public FNiagaraVariableBase ParamMapVariable;
	public FName DataSetName;
	public FNiagaraVariable BoundVariable;
	public FName CachedDisplayName;
	public ENiagaraBindingSource BindingSourceMode;
	public bool bBindingExistsOnSource;
	public bool bIsCachedParticleValue;
	public FNiagaraVariable DataSetVariable_DEPRECATED;
}
