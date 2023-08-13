namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Extension of the base parameter store to allow the user in the editor to use variable names without</summary>
[CppInclude("NiagaraUserRedirectionParameterStore.h")]
public partial struct FNiagaraUserRedirectionParameterStore {
	public TMap<FNiagaraVariable,FNiagaraVariable> UserParameterRedirects;
}
