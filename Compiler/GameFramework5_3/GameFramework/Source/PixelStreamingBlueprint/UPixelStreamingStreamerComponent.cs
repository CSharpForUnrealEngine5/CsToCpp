namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelStreamingStreamerComponent.h")]
public partial class UPixelStreamingStreamerComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>GetId</summary>
	public string GetId() { return default; }
	///<summary>IsSignallingConnected</summary>
	public bool IsSignallingConnected() { return default; }
	///<summary>StartStreaming</summary>
	public void StartStreaming() {}
	///<summary>StopStreaming</summary>
	public void StopStreaming() {}
	///<summary>IsStreaming</summary>
	public bool IsStreaming() { return default; }
	///<summary>ForceKeyFrame</summary>
	public void ForceKeyFrame() {}
	///<summary>FreezeStream</summary>
	public void FreezeStream(UTexture2D Texture) {}
	///<summary>UnfreezeStream</summary>
	public void UnfreezeStream() {}
	///<summary>SendPlayerMessage</summary>
	public void SendPlayerMessage(byte Type,string Descriptor) {}
	///<summary>StreamerId</summary>
	public string StreamerId;
	///<summary>SignallingServerURL</summary>
	public string SignallingServerURL;
	///<summary>StreamFPS</summary>
	public int StreamFPS;
	///<summary>CoupleFramerate</summary>
	public bool CoupleFramerate;
	///<summary>VideoInput</summary>
	public UPixelStreamingStreamerVideoInput VideoInput;
}
