namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Customizations/NiagaraScriptVariableCustomization.h")]
///<summary>Intermediate representations for default mode set on parameter definition script variables. Maps to ENiagaraDefaultMode and bOverrideParameterDefinitionsDefaultValue of UNiagaraScriptVariable.</summary>
public enum ENiagaraLibrarySynchronizedDefaultMode {
	Definition=0,
	Value=1,
	Binding=2,
	Custom=3,
	FailIfPreviouslyNotSet=4,
}
