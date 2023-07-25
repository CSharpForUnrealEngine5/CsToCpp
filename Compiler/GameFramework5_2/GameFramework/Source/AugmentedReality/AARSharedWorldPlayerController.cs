#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSharedWorldPlayerController.h")]
public partial class AARSharedWorldPlayerController : APlayerController {
// ARSharedWorldPlayerController
	public void ServerMarkReadyForReceiving() {}
	public void ClientInitSharedWorld(int PreviewImageSize,int ARWorldDataSize) {}
	public void ClientUpdatePreviewImageData(int Offset,TArray<byte> Buffer) {}
	public void ClientUpdateARWorldData(int Offset,TArray<byte> Buffer) {}
}
