#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPFullScreenUserWidget.h")]
public partial struct FVPFullScreenUserWidget_PostProcess {
	public UMaterialInterface PostProcessMaterial;
	public FLinearColor PostProcessTintColorAndOpacity;
	public float PostProcessOpacityFromTexture;
	public bool bWidgetDrawSize;
	public FIntPoint WidgetDrawSize;
	public bool bWindowFocusable;
	public EWindowVisibility WindowVisibility;
	public bool bReceiveHardwareInput;
	public FLinearColor RenderTargetBackgroundColor;
	public EWidgetBlendMode RenderTargetBlendMode;
	public TArray<ACompositingElement> ComposureLayerTargets;
	public UTextureRenderTarget2D WidgetRenderTarget;
	public UPostProcessComponent PostProcessComponent;
	public UMaterialInstanceDynamic PostProcessMaterialInstance;
}
