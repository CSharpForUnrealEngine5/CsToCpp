#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/WidgetComponent.h")]
///<summary>The widget component provides a surface in the 3D environment on which to render widgets normally rendered to the screen.</summary>
public partial class UWidgetComponent : UMeshComponent {
// WidgetComponent
	public  UUserWidget GetUserWidgetObject() { return default; }
	public  UTextureRenderTarget2D GetRenderTarget() { return default; }
	public  UMaterialInstanceDynamic GetMaterialInstance() { return default; }
	public  UUserWidget GetWidget() { return default; }
	public  void SetWidget(UUserWidget Widget) {}
	public  void SetOwnerPlayer(ULocalPlayer LocalPlayer) {}
	public  bool GetManuallyRedraw() { return default; }
	public  void SetManuallyRedraw(bool bUseManualRedraw) {}
	public  ULocalPlayer GetOwnerPlayer() { return default; }
	public  FVector2D GetDrawSize() { return default; }
	public  FVector2D GetCurrentDrawSize() { return default; }
	public  void SetDrawSize(FVector2D Size) {}
	public  void RequestRedraw() {}
	public  void RequestRenderUpdate() {}
	public  bool GetTwoSided() { return default; }
	public  void SetTwoSided(bool bWantTwoSided) {}
	public  bool GetTickWhenOffscreen() { return default; }
	public  void SetTickWhenOffscreen(bool bWantTickWhenOffscreen) {}
	public  void SetBackgroundColor(FLinearColor NewBackgroundColor) {}
	public  void SetTintColorAndOpacity(FLinearColor NewTintColorAndOpacity) {}
	public  FVector2D GetPivot() { return default; }
	public  void SetPivot(FVector2D InPivot) {}
	public  bool GetDrawAtDesiredSize() { return default; }
	public  void SetDrawAtDesiredSize(bool bInDrawAtDesiredSize) {}
	public  float GetRedrawTime() { return default; }
	public  void SetRedrawTime(float InRedrawTime) {}
	public  EWidgetSpace GetWidgetSpace() { return default; }
	public  void SetWidgetSpace(EWidgetSpace NewSpace) {}
	public  EWidgetGeometryMode GetGeometryMode() { return default; }
	public  void SetGeometryMode(EWidgetGeometryMode InGeometryMode) {}
	public  float GetCylinderArcAngle() { return default; }
	public  void SetCylinderArcAngle(float InCylinderArcAngle) {}
	public  bool GetWindowFocusable() { return default; }
	public  void SetWindowFocusable(bool bInWindowFocusable) {}
	public  EWindowVisibility GetWindowVisiblility() { return default; }
	public  void SetWindowVisibility(EWindowVisibility InVisibility) {}
	public  void SetTickMode(ETickMode InTickMode) {}
	public  bool IsWidgetVisible() { return default; }
	public EWidgetSpace Space;
	public EWidgetTimingPolicy TimingPolicy;
	public UClass WidgetClass;
	public FIntPoint DrawSize;
	public bool bManuallyRedraw;
	public bool bRedrawRequested;
	public float RedrawTime;
	public FIntPoint CurrentDrawSize;
	public bool bDrawAtDesiredSize;
	public FVector2D Pivot;
	public bool bReceiveHardwareInput;
	public bool bWindowFocusable;
	public EWindowVisibility WindowVisibility;
	public bool bApplyGammaCorrection;
	public ULocalPlayer OwnerPlayer;
	public FLinearColor BackgroundColor;
	public FLinearColor TintColorAndOpacity;
	public float OpacityFromTexture;
	public EWidgetBlendMode BlendMode;
	public bool bIsTwoSided;
	public bool TickWhenOffscreen;
	public UBodySetup BodySetup;
	public UMaterialInterface TranslucentMaterial;
	public UMaterialInterface TranslucentMaterial_OneSided;
	public UMaterialInterface OpaqueMaterial;
	public UMaterialInterface OpaqueMaterial_OneSided;
	public UMaterialInterface MaskedMaterial;
	public UMaterialInterface MaskedMaterial_OneSided;
	public UTextureRenderTarget2D RenderTarget;
	public UMaterialInstanceDynamic MaterialInstance;
	public bool bAddedToScreen;
	public bool bEditTimeUsable;
	public string SharedLayerName;
	public int LayerZOrder;
	public EWidgetGeometryMode GeometryMode;
	public float CylinderArcAngle;
	public ETickMode TickMode;
	public UUserWidget Widget;
}
