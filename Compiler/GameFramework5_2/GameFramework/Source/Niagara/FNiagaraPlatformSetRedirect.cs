#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows us to replace a specific device profile usage condition in all NiagaraPlatformSets.</summary>
[CppInclude("NiagaraPlatformSet.h")]
public partial struct FNiagaraPlatformSetRedirect {
	public TArray<string> ProfileNames;
	public ENiagaraDeviceProfileRedirectMode Mode;
	public string RedirectProfileName;
	public FNiagaraPlatformSetCVarCondition CVarConditionEnabled;
	public FNiagaraPlatformSetCVarCondition CVarConditionDisabled;
}
