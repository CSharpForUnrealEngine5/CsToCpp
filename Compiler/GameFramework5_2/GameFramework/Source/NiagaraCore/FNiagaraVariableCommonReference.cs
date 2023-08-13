namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A utility class allowing for references to FNiagaraVariableBase outside of the Niagara module.</summary>
[CppInclude("NiagaraCore.h")]
public partial struct FNiagaraVariableCommonReference {
	public string Name;
	public UObject UnderlyingType;
}
