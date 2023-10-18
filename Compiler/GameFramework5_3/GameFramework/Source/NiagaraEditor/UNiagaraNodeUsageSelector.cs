namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeUsageSelector.h")]
public partial class UNiagaraNodeUsageSelector : UNiagaraNodeWithDynamicPins {
	public static UClass StaticClass() {return default;}
	///<summary>OutputVars</summary>
	public TArray<FNiagaraVariable> OutputVars;
	///<summary>OutputVarGuids</summary>
	public TArray<FGuid> OutputVarGuids;
	///<summary>SelectorGuid</summary>
	public FGuid SelectorGuid;
	///<summary>Primarily used for integer options where the number of entries is not derivable from something else (i.e. enum or bool which clearly define entries)</summary>
	public int NumOptionsPerVariable;
}
