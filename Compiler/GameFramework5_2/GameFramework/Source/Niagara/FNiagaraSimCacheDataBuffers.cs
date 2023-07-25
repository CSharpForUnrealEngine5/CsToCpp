#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCache.h")]
public partial struct FNiagaraSimCacheDataBuffers {
// NiagaraSimCacheDataBuffers
	public uint NumInstances;
	public TArray<byte> FloatData;
	public TArray<byte> HalfData;
	public TArray<byte> Int32Data;
	public TArray<int> IDToIndexTable;
	public uint IDAcquireTag;
	public TArray<uint> InterpMapping;
}
