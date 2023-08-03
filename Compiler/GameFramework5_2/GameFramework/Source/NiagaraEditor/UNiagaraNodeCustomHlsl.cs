#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeCustomHlsl.h")]
public partial class UNiagaraNodeCustomHlsl : UNiagaraNodeFunctionCall {
	public static UClass StaticClass() {return default;}
	///<summary>ScriptUsage</summary>
	public ENiagaraScriptUsage ScriptUsage;
	///<summary>CustomHlsl</summary>
	public string CustomHlsl;
	///<summary>Links to hlsl files that will be included by the translator. These external files are not watched by the engine, so changes to them do not automatically trigger a recompile of Niagara scripts.</summary>
	public TArray<FFilePath> AbsoluteIncludeFilePaths;
	///<summary>Links to hlsl files that will be included by the translator. These paths are resolved with the virtual shader paths registered in the engine.</summary>
	public TArray<string> VirtualIncludeFilePaths;
	///<summary>Is the shader code UI shown?</summary>
	public bool bIsShaderCodeShown;
}
