#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcVideoCaptureDevice.h")]
public partial class UAsyncTask_OpenMrcVidCaptureFeedBase : UBlueprintAsyncActionBase {
	public static UClass StaticClass() {return default;}
	///<summary>OnSuccess</summary>
	public FMRCaptureFeedDelegate OnSuccess;
	///<summary>OnFail</summary>
	public FMRCaptureFeedDelegate OnFail;
	///<summary>OnVideoFeedOpened</summary>
	public  void OnVideoFeedOpened(string DeviceUrl) {}
	///<summary>OnVideoFeedOpenFailure</summary>
	public  void OnVideoFeedOpenFailure(string DeviceUrl) {}
	///<summary>MediaPlayer</summary>
	public UMediaPlayer MediaPlayer;
}
