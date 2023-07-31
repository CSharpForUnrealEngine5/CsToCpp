#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSharedWorldGameMode.h")]
public partial class AARSharedWorldGameMode : AGameMode {
	///<summary>The size of the buffer to use per send request. Must be between 1 and 65535, though should not be max to avoid saturation</summary>
	public int BufferSizePerChunk;
	///<summary>Sets the image data for the shared world game session</summary>
	public  void SetPreviewImageData(TArray<byte> ImageData) {}
	///<summary>Sets the image data for the shared world game session</summary>
	public  void SetARSharedWorldData(TArray<byte> ARWorldData) {}
	///<summary>Tells the game mode that the AR data is ready and should be replicated to all connected clients</summary>
	public  void SetARWorldSharingIsReady() {}
	///<summary>@return the game state for this game mode</summary>
	public  AARSharedWorldGameState GetARSharedWorldGameState() { return default; }
}
