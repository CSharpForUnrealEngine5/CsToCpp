namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannel.h")]
public partial class UNiagaraDataChannel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The variables that define the data contained in this Data Channel.</summary>
	public TArray<FNiagaraVariable> Variables;
	///<summary>If true, we keep our previous frame&#39;s data. This comes at a memory and performance cost but allows users to avoid tick order dependency by reading last frame&#39;s data. Some users will prefer a frame of latency to tick order dependency.</summary>
	public bool bKeepPreviousFrameData;
	///<summary>Data layout for payloads in Niagara datasets.</summary>
	public FNiagaraDataSetCompiledData CompiledData;
	///<summary>CompiledDataGPU</summary>
	public FNiagaraDataSetCompiledData CompiledDataGPU;
}
