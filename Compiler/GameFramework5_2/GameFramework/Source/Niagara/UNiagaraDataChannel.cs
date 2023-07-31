#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannel.h")]
public partial class UNiagaraDataChannel : UObject {
	///<summary>ChannelName</summary>
	public string ChannelName;
	///<summary>The variables that define the data contained in this Data Channel.</summary>
	public TArray<FNiagaraVariable> Variables;
	///<summary>If true, we keep our previous frame&#39;s data. Some users will prefer a frame of latency to tick dependency.</summary>
	public bool bKeepPreviousFrameData;
	///<summary>Data layout for payloads in Niagara datasets.</summary>
	public FNiagaraDataSetCompiledData CompiledData;
	///<summary>CompiledDataGPU</summary>
	public FNiagaraDataSetCompiledData CompiledDataGPU;
	///<summary>Layout information for any data stored at the &quot;Game&quot; level. i.e. From game code/BP. AoS layout and LWC types.</summary>
	public FNiagaraDataChannelGameDataLayout GameDataLayout;
}
