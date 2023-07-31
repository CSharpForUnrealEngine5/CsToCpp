#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSharedWorldGameState.h")]
public partial class AARSharedWorldGameState : AGameState {
	///<summary>The image taken at the time of world saving for use when aligning the AR world later in the session</summary>
	public TArray<byte> PreviewImageData;
	///<summary>Each client and the host have a copy of the shared world data</summary>
	public TArray<byte> ARWorldData;
	///<summary>The size of the image that will be replicated to each client</summary>
	public int PreviewImageBytesTotal;
	///<summary>The size of the AR world data that will be replicated to each client</summary>
	public int ARWorldBytesTotal;
	///<summary>The amount of the preview image data that has been replicated to this client so far</summary>
	public int PreviewImageBytesDelivered;
	///<summary>The amount of the AR world data that has been replicated to this client so far</summary>
	public int ARWorldBytesDelivered;
	///<summary>K2_OnARWorldMapIsReady</summary>
	public  void K2_OnARWorldMapIsReady() {}
}
