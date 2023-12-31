namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceDataChannelWrite.h")]
public partial class UNiagaraDataInterfaceDataChannelWrite : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>How should we allocate the buffer into which we write data.</summary>
	public ENiagaraDataChannelAllocationMode AllocationMode;
	///<summary>How many elements to allocate for writing per frame? Usage is defendant on AllocationMode. TODO: Allow allocation count to be controlled dynamically from script?</summary>
	public uint AllocationCount;
	///<summary>Whether the data generated by this DI should be published to the world game data channel. This is require to allow game BP and C++ to read this data.</summary>
	public bool bPublishToGame;
	///<summary>Whether the data generated by this DI should be published to the world CPUSim data channel. This is required for CPU emitters in other Niagara Systems to read this data.</summary>
	public bool bPublishToCPU;
	///<summary>Whether the data generated by this DI should be published to a world data channel. This is required to allow GPU emitters in other Niagara Systems to read this data.</summary>
	public bool bPublishToGPU;
	///<summary>When writing externally, the channel to use.</summary>
	public FNiagaraDataChannelReference Channel;
	///<summary>CompiledData</summary>
	public FNDIDataChannelWriteCompiledData CompiledData;
}
