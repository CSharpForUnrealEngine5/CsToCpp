namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data for a single data channel island.</summary>
[CppInclude("NiagaraDataChannel_Islands.h")]
public partial struct FNDCIsland {
	public UNiagaraDataChannelHandler_Islands Owner;
	public FBoxSphereBounds Bounds;
	public TArray<UNiagaraComponent> NiagaraSystems;
}
