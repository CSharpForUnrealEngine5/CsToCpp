#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
	///<summary>NumOptionsPerVariable</summary>
	public int NumOptionsPerVariable;
}
