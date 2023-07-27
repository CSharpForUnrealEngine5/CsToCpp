#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingBlueprints.h")]
public partial class UPixelStreamingBlueprints : UBlueprintFunctionLibrary {
// PixelStreamingBlueprints
	public static void SendFileAsByteArray(TArray<byte> ByteArray,string MimeType,string FileExtension) {}
	public static void StreamerSendFileAsByteArray(string StreamerId,TArray<byte> ByteArray,string MimeType,string FileExtension) {}
	public static void SendFile(string Filepath,string MimeType,string FileExtension) {}
	public static void StreamerSendFile(string StreamerId,string Filepath,string MimeType,string FileExtension) {}
	public static void ForceKeyFrame() {}
	public static void FreezeFrame(UTexture2D Texture) {}
	public static void UnfreezeFrame() {}
	public static void StreamerFreezeStream(string StreamerId,UTexture2D Texture) {}
	public static void StreamerUnfreezeStream(string StreamerId) {}
	public static void KickPlayer(string PlayerId) {}
	public static void StreamerKickPlayer(string StreamerId,string PlayerId) {}
	public static string GetDefaultStreamerID() { return default; }
	public static UPixelStreamingDelegates GetPixelStreamingDelegates() { return default; }
}
