namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraMaterialAttributeBinding {
	public FName MaterialParameterName;
	public FNiagaraVariableBase NiagaraVariable;
	public FNiagaraVariableBase ResolvedNiagaraVariable;
	public FNiagaraVariableBase NiagaraChildVariable;
}
