#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcVideoCaptureDevice.h")]
public partial class UAsyncTask_OpenMrcVidCaptureFeedBase : UBlueprintAsyncActionBase {
// AsyncTask_OpenMrcVidCaptureFeedBase
	public FMRCaptureFeedDelegate OnSuccess;
	public FMRCaptureFeedDelegate OnFail;
	public void OnVideoFeedOpened(string DeviceUrl) {}
	public void OnVideoFeedOpenFailure(string DeviceUrl) {}
	public UMediaPlayer MediaPlayer;
}
