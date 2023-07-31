#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines all you need to know about a variable.</summary>
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraVariableInfo {
	public FNiagaraVariable Variable;
	public string Definition;
	public UNiagaraDataInterface DataInterface;
}
