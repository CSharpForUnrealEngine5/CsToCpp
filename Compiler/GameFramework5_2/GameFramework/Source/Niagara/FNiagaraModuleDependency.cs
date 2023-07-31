#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScript.h")]
public partial struct FNiagaraModuleDependency {
	public string Id;
	public ENiagaraModuleDependencyType Type;
	public ENiagaraModuleDependencyScriptConstraint ScriptConstraint;
	public string RequiredVersion;
	public int OnlyEvaluateInScriptUsage;
	public string Description;
}
