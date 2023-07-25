#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingBlueprints.h")]
public partial class UPixelStreamingBlueprints : UBlueprintFunctionLibrary {
// PixelStreamingBlueprints
	public void SendFileAsByteArray(TArray<byte> ByteArray,string MimeType,string FileExtension) {}
	public void StreamerSendFileAsByteArray(string StreamerId,TArray<byte> ByteArray,string MimeType,string FileExtension) {}
	public void SendFile(string Filepath,string MimeType,string FileExtension) {}
	public void StreamerSendFile(string StreamerId,string Filepath,string MimeType,string FileExtension) {}
	public void ForceKeyFrame() {}
	public void FreezeFrame(UObject Texture) {}
	public void UnfreezeFrame() {}
	public void StreamerFreezeStream(string StreamerId,UObject Texture) {}
	public void StreamerUnfreezeStream(string StreamerId) {}
	public void KickPlayer(string PlayerId) {}
	public void StreamerKickPlayer(string StreamerId,string PlayerId) {}
	public string GetDefaultStreamerID() { return default; }
	public UObject GetPixelStreamingDelegates() { return default; }
}
