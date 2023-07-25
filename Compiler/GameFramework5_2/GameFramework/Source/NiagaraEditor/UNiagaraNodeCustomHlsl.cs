#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeCustomHlsl.h")]
public partial class UNiagaraNodeCustomHlsl : UNiagaraNodeFunctionCall {
// NiagaraNodeCustomHlsl
	public ENiagaraScriptUsage ScriptUsage;
	public string CustomHlsl;
	public TArray<FFilePath> AbsoluteIncludeFilePaths;
	public TArray<string> VirtualIncludeFilePaths;
	public bool bIsShaderCodeShown;
}
