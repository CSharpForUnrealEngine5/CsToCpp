namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A sorted table of parameters accessed by each GPU script</summary>
[CppInclude("DataInterface/NiagaraDataInterfaceDataChannelCommon.h")]
public partial struct FNDIDataChannel_GPUScriptParameterAccessInfo {
	public TArray<FNiagaraVariableBase> SortedParameters;
}
