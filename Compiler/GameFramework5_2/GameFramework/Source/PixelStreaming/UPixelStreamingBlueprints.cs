#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingBlueprints.h")]
public partial class UPixelStreamingBlueprints : UBlueprintFunctionLibrary {
	///<summary>Send a specified byte array over the WebRTC peer connection data channel. The extension and mime type are used for file reconstruction on the front end</summary>
	public static void SendFileAsByteArray(TArray<byte> ByteArray,string MimeType,string FileExtension) {}
	///<summary>Send a specified byte array over the WebRTC peer connection data channel. The extension and mime type are used for file reconstruction on the front end</summary>
	public static void StreamerSendFileAsByteArray(string StreamerId,TArray<byte> ByteArray,string MimeType,string FileExtension) {}
	///<summary>Send a specified file over the WebRTC peer connection data channel. The extension and mime type are used for file reconstruction on the front end</summary>
	public static void SendFile(string Filepath,string MimeType,string FileExtension) {}
	///<summary>Send a specified file over the WebRTC peer connection data channel. The extension and mime type are used for file reconstruction on the front end</summary>
	public static void StreamerSendFile(string StreamerId,string Filepath,string MimeType,string FileExtension) {}
	///<summary>Force a key frame to be sent.</summary>
	public static void ForceKeyFrame() {}
	///<summary>Freeze Pixel Streaming.</summary>
	public static void FreezeFrame(UTexture2D Texture) {}
	///<summary>Unfreeze Pixel Streaming.</summary>
	public static void UnfreezeFrame() {}
	///<summary>Freeze Pixel Streaming.</summary>
	public static void StreamerFreezeStream(string StreamerId,UTexture2D Texture) {}
	///<summary>Unfreeze Pixel Streaming.</summary>
	public static void StreamerUnfreezeStream(string StreamerId) {}
	///<summary>Kick a player.</summary>
	public static void KickPlayer(string PlayerId) {}
	///<summary>Kick a player.</summary>
	public static void StreamerKickPlayer(string StreamerId,string PlayerId) {}
	///<summary>Get the default Streamer ID</summary>
	public static string GetDefaultStreamerID() { return default; }
	///<summary>Get the singleton. This allows application-specific blueprints to bind</summary>
	public static UPixelStreamingDelegates GetPixelStreamingDelegates() { return default; }
}
