namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraPlatformSet.h")]
public partial struct FNiagaraPlatformSet {
	public TArray<FNiagaraDeviceProfileStateEntry> DeviceProfileStates;
	public TArray<FNiagaraPlatformSetCVarCondition> CVarConditions;
	public int QualityLevelMask;
}
