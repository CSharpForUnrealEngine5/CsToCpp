#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSharedWorldGameMode.h")]
public partial class AARSharedWorldGameMode : AGameMode {
// ARSharedWorldGameMode
	public int BufferSizePerChunk;
	public  void SetPreviewImageData(TArray<byte> ImageData) {}
	public  void SetARSharedWorldData(TArray<byte> ARWorldData) {}
	public  void SetARWorldSharingIsReady() {}
	public  AARSharedWorldGameState GetARSharedWorldGameState() { return default; }
}
