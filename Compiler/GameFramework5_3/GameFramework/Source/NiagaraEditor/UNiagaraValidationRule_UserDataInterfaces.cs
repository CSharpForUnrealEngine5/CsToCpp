namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This validation rule checks to see if you have exposed user data interfaces.</summary>
[CppInclude("NiagaraValidationRules.h")]
public partial class UNiagaraValidationRule_UserDataInterfaces : UNiagaraValidationRule {
	public static UClass StaticClass() {return default;}
	///<summary>Only include data interfaces that contain exposed UObject properties in them.</summary>
	public bool bOnlyIncludeExposedUObjects;
	///<summary>List data interfaces to validate against, if this list is empty all data interfaces will be included.</summary>
	public TArray<UClass> BannedDataInterfaces;
	///<summary>List data interfaces that we always allow.</summary>
	public TArray<UClass> AllowDataInterfaces;
	///<summary>How do we want to repro the error in the stack</summary>
	public ENiagaraValidationSeverity Severity;
}
