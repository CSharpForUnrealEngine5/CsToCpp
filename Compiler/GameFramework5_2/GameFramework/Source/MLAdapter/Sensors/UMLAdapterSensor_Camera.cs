#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sensors/MLAdapterSensor_Camera.h")]
///<summary>Observing player's camera</summary>
public partial class UMLAdapterSensor_Camera : UMLAdapterSensor {
// MLAdapterSensor_Camera
	public uint Width;
	public uint Height;
	public bool bShowUI;
	public USceneCaptureComponent2D CaptureComp;
	public UTextureRenderTarget2D RenderTarget2D;
	public UGameViewportClient CachedViewportClient;
}
