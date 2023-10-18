namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This validation rule that can be used to inform or ban GPU usage on the provided platforms.</summary>
[CppInclude("NiagaraValidationRules.h")]
public partial class UNiagaraValidationRule_GpuUsage : UNiagaraValidationRule {
	public static UClass StaticClass() {return default;}
	///<summary>Severity</summary>
	public ENiagaraValidationSeverity Severity;
	///<summary>Platforms</summary>
	public FNiagaraPlatformSet Platforms;
}
