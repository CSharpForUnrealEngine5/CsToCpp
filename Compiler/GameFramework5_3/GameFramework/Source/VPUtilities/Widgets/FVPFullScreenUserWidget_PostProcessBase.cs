namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements shared widget initialization logic.</summary>
[CppInclude("Widgets/Fullscreen/VPFullScreenUserWidget_PostProcessBase.h")]
public partial struct FVPFullScreenUserWidget_PostProcessBase {
	public UMaterialInterface PostProcessMaterial;
	public FLinearColor PostProcessTintColorAndOpacity;
	public float PostProcessOpacityFromTexture;
	public bool bUseWidgetDrawSize;
	public FIntPoint WidgetDrawSize;
	public bool bWindowFocusable;
	public EWindowVisibility WindowVisibility;
	public bool bReceiveHardwareInput;
	public FLinearColor RenderTargetBackgroundColor;
	public EWidgetBlendMode RenderTargetBlendMode;
	public UTextureRenderTarget2D WidgetRenderTarget;
}
