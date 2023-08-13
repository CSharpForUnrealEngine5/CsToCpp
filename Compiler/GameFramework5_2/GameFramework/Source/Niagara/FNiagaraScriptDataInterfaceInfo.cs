namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraScriptDataInterfaceInfo {
	public UNiagaraDataInterface DataInterface;
	public string Name;
	public int UserPtrIdx;
	public FNiagaraTypeDefinition Type;
	public string RegisteredParameterMapRead;
	public string RegisteredParameterMapWrite;
}
