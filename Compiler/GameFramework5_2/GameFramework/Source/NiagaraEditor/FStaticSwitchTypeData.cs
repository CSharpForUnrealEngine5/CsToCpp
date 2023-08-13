namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeStaticSwitch.h")]
public partial struct FStaticSwitchTypeData {
	public ENiagaraStaticSwitchType SwitchType;
	public UEnum Enum;
	public string SwitchConstant;
	public bool bAutoRefreshEnabled;
	public bool bExposeAsPin;
}
