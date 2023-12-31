namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows us to replace a specific device profile usage condition in all NiagaraPlatformSets.</summary>
[CppInclude("NiagaraPlatformSet.h")]
public partial struct FNiagaraPlatformSetRedirect {
	public TArray<FName> ProfileNames;
	public ENiagaraDeviceProfileRedirectMode Mode;
	public FName RedirectProfileName;
	public FNiagaraPlatformSetCVarCondition CVarConditionEnabled;
	public FNiagaraPlatformSetCVarCondition CVarConditionDisabled;
}
