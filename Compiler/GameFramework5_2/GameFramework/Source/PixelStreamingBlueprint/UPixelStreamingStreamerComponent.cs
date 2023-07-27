#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingStreamerComponent.h")]
public partial class UPixelStreamingStreamerComponent : UActorComponent {
// PixelStreamingStreamerComponent
	public  string GetId() { return default; }
	public  bool IsSignallingConnected() { return default; }
	public  void StartStreaming() {}
	public  void StopStreaming() {}
	public  bool IsStreaming() { return default; }
	public  void ForceKeyFrame() {}
	public  void FreezeStream(UTexture2D Texture) {}
	public  void UnfreezeStream() {}
	public  void SendPlayerMessage(byte Type,string Descriptor) {}
	public string StreamerId;
	public string SignallingServerURL;
	public int StreamFPS;
	public bool CoupleFramerate;
	public UPixelStreamingStreamerVideoInput VideoInput;
}
