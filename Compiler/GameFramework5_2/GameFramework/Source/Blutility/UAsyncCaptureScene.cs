#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncCaptureScene.h")]
public partial class UAsyncCaptureScene : UBlueprintAsyncActionBase {
// AsyncCaptureScene
	public static UAsyncCaptureScene CaptureSceneAsync(UCameraComponent ViewCamera,UClass SceneCaptureClass,int ResX,int ResY) { return default; }
	public static UAsyncCaptureScene CaptureSceneWithWarmupAsync(UCameraComponent ViewCamera,UClass SceneCaptureClass,int ResX,int ResY,int WarmUpFrames) { return default; }
	public FOnAsyncCaptureSceneComplete Complete;
	public ASceneCapture2D SceneCapture;
	public UTextureRenderTarget2D SceneCaptureRT;
}
