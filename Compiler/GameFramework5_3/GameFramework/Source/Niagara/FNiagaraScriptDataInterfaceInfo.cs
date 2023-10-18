namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraScriptDataInterfaceInfo {
	public UNiagaraDataInterface DataInterface;
	public FName Name;
	public FName CompileName;
	public int UserPtrIdx;
	public FNiagaraTypeDefinition Type;
	public FName RegisteredParameterMapRead;
	public FName RegisteredParameterMapWrite;
	public string SourceEmitterName;
}
