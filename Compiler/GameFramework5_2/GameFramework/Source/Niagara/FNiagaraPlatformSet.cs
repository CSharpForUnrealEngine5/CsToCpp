namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraPlatformSet.h")]
public partial struct FNiagaraPlatformSet {
	public int QualityLevelMask;
	public TArray<FNiagaraDeviceProfileStateEntry> DeviceProfileStates;
	public TArray<FNiagaraPlatformSetCVarCondition> CVarConditions;
}
