#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSharedWorldGameState.h")]
public partial class AARSharedWorldGameState : AGameState {
// ARSharedWorldGameState
	public TArray<byte> PreviewImageData;
	public TArray<byte> ARWorldData;
	public int PreviewImageBytesTotal;
	public int ARWorldBytesTotal;
	public int PreviewImageBytesDelivered;
	public int ARWorldBytesDelivered;
	public  void K2_OnARWorldMapIsReady() {}
}
