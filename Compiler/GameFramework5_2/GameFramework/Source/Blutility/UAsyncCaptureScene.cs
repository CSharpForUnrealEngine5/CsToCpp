#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncCaptureScene.h")]
public partial class UAsyncCaptureScene : UBlueprintAsyncActionBase {
	///<summary>CaptureSceneAsync</summary>
	public static UAsyncCaptureScene CaptureSceneAsync(UCameraComponent ViewCamera,UClass SceneCaptureClass,int ResX,int ResY) { return default; }
	///<summary>CaptureSceneWithWarmupAsync</summary>
	public static UAsyncCaptureScene CaptureSceneWithWarmupAsync(UCameraComponent ViewCamera,UClass SceneCaptureClass,int ResX,int ResY,int WarmUpFrames) { return default; }
	///<summary>Complete</summary>
	public FOnAsyncCaptureSceneComplete Complete;
	///<summary>SceneCapture</summary>
	public ASceneCapture2D SceneCapture;
	///<summary>SceneCaptureRT</summary>
	public UTextureRenderTarget2D SceneCaptureRT;
}
