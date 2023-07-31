#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSharedWorldPlayerController.h")]
public partial class AARSharedWorldPlayerController : APlayerController {
	///<summary>Tells the server it is ready for receiving any shared world data</summary>
	public  void ServerMarkReadyForReceiving() {}
	///<summary>Used to setup the initial values and size the arrays (client)</summary>
	public  void ClientInitSharedWorld(int PreviewImageSize,int ARWorldDataSize) {}
	///<summary>Copies the buffer into the image data (client)</summary>
	public  void ClientUpdatePreviewImageData(int Offset,TArray<byte> Buffer) {}
	///<summary>Copies the buffer into the AR world data (client)</summary>
	public  void ClientUpdateARWorldData(int Offset,TArray<byte> Buffer) {}
}
