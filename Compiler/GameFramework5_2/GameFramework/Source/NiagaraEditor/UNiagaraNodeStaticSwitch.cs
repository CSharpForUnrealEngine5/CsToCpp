namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeStaticSwitch.h")]
public partial class UNiagaraNodeStaticSwitch : UNiagaraNodeUsageSelector {
	public static UClass StaticClass() {return default;}
	///<summary>InputParameterName</summary>
	public FName InputParameterName;
	///<summary>SwitchTypeData</summary>
	public FStaticSwitchTypeData SwitchTypeData;
}
