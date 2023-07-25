#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraPlatformSet.h")]
///<summary>Allows us to replace a specific device profile usage condition in all NiagaraPlatformSets.</summary>
public partial struct FNiagaraPlatformSetRedirect {
// NiagaraPlatformSetRedirect
	public TArray<string> ProfileNames;
	public ENiagaraDeviceProfileRedirectMode Mode;
	public string RedirectProfileName;
	public FNiagaraPlatformSetCVarCondition CVarConditionEnabled;
	public FNiagaraPlatformSetCVarCondition CVarConditionDisabled;
}
