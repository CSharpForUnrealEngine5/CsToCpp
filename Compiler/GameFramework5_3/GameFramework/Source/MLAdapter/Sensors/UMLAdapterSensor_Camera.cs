namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Observing player&#39;s camera</summary>
[CppInclude("Sensors/MLAdapterSensor_Camera.h")]
public partial class UMLAdapterSensor_Camera : UMLAdapterSensor {
	public static UClass StaticClass() {return default;}
	///<summary>Width</summary>
	public uint Width;
	///<summary>Height</summary>
	public uint Height;
	///<summary>bShowUI</summary>
	public bool bShowUI;
	///<summary>CaptureComp</summary>
	public USceneCaptureComponent2D CaptureComp;
	///<summary>RenderTarget2D</summary>
	public UTextureRenderTarget2D RenderTarget2D;
	///<summary>CachedViewportClient</summary>
	public UGameViewportClient CachedViewportClient;
}
