namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScript.h")]
public partial struct FNiagaraModuleDependency {
	public string Id;
	public ENiagaraModuleDependencyType Type;
	public ENiagaraModuleDependencyScriptConstraint ScriptConstraint;
	public string RequiredVersion;
	public int OnlyEvaluateInScriptUsage;
	public FText Description;
}
