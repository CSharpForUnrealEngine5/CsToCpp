namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines all you need to know about a variable.</summary>
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraVariableInfo {
	public FNiagaraVariable Variable;
	public FText Definition;
	public UNiagaraDataInterface DataInterface;
}
