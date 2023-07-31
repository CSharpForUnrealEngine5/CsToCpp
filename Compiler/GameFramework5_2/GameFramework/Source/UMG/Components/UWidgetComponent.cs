#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The widget component provides a surface in the 3D environment on which to render widgets normally rendered to the screen.</summary>
[CppInclude("Components/WidgetComponent.h")]
public partial class UWidgetComponent : UMeshComponent {
	///<summary>Returns the user widget object displayed by this component</summary>
	public  UUserWidget GetUserWidgetObject() { return default; }
	///<summary>Returns the render target to which the user widget is rendered</summary>
	public  UTextureRenderTarget2D GetRenderTarget() { return default; }
	///<summary>Returns the dynamic material instance used to render the user widget</summary>
	public  UMaterialInstanceDynamic GetMaterialInstance() { return default; }
	///<summary>Gets the widget that is used by this Widget Component. It will be null if a Slate Widget was set using SetSlateWidget function.</summary>
	public  UUserWidget GetWidget() { return default; }
	///<summary>Sets the widget to use directly. This function will keep track of the widget till the next time it&#39;s called</summary>
	public  void SetWidget(UUserWidget Widget) {}
	///<summary>Sets the local player that owns this widget component.  Setting the owning player controls</summary>
	public  void SetOwnerPlayer(ULocalPlayer LocalPlayer) {}
	///<summary>See: bManuallyRedraw</summary>
	public  bool GetManuallyRedraw() { return default; }
	///<summary>See: bManuallyRedraw</summary>
	public  void SetManuallyRedraw(bool bUseManualRedraw) {}
	///<summary>Gets the local player that owns this widget component.</summary>
	public  ULocalPlayer GetOwnerPlayer() { return default; }
	///<summary>Returns the &quot;specified&quot; draw size of the quad in the world</summary>
	public  FVector2D GetDrawSize() { return default; }
	///<summary>Returns the &quot;actual&quot; draw size of the quad in the world</summary>
	public  FVector2D GetCurrentDrawSize() { return default; }
	///<summary>Sets the draw size of the quad in the world</summary>
	public  void SetDrawSize(FVector2D Size) {}
	///<summary>Requests that the widget be redrawn.</summary>
	public  void RequestRedraw() {}
	///<summary>Requests that the widget have it&#39;s render target updated, if TickMode is disabled, this will force a tick to happen to update the render target.</summary>
	public  void RequestRenderUpdate() {}
	///<summary>Gets whether the widget is two-sided or not</summary>
	public  bool GetTwoSided() { return default; }
	///<summary>Sets whether the widget is two-sided or not</summary>
	public  void SetTwoSided(bool bWantTwoSided) {}
	///<summary>Gets whether the widget ticks when offscreen or not</summary>
	public  bool GetTickWhenOffscreen() { return default; }
	///<summary>Sets whether the widget ticks when offscreen or not</summary>
	public  void SetTickWhenOffscreen(bool bWantTickWhenOffscreen) {}
	///<summary>Sets the background color and opacityscale for this widget</summary>
	public  void SetBackgroundColor(FLinearColor NewBackgroundColor) {}
	///<summary>Sets the tint color and opacity scale for this widget</summary>
	public  void SetTintColorAndOpacity(FLinearColor NewTintColorAndOpacity) {}
	///<summary>Returns the pivot point where the UI is rendered about the origin.</summary>
	public  FVector2D GetPivot() { return default; }
	///<summary>SetPivot</summary>
	public  void SetPivot(FVector2D InPivot) {}
	///<summary>GetDrawAtDesiredSize</summary>
	public  bool GetDrawAtDesiredSize() { return default; }
	///<summary>SetDrawAtDesiredSize</summary>
	public  void SetDrawAtDesiredSize(bool bInDrawAtDesiredSize) {}
	///<summary>GetRedrawTime</summary>
	public  float GetRedrawTime() { return default; }
	///<summary>SetRedrawTime</summary>
	public  void SetRedrawTime(float InRedrawTime) {}
	///<summary>GetWidgetSpace</summary>
	public  EWidgetSpace GetWidgetSpace() { return default; }
	///<summary>SetWidgetSpace</summary>
	public  void SetWidgetSpace(EWidgetSpace NewSpace) {}
	///<summary>See: EWidgetGeometryMode, See: GetCylinderArcAngle()</summary>
	public  EWidgetGeometryMode GetGeometryMode() { return default; }
	///<summary>SetGeometryMode</summary>
	public  void SetGeometryMode(EWidgetGeometryMode InGeometryMode) {}
	///<summary>Defines the curvature of the widget component when using EWidgetGeometryMode::Cylinder; ignored otherwise.</summary>
	public  float GetCylinderArcAngle() { return default; }
	///<summary>Defines the curvature of the widget component when using EWidgetGeometryMode::Cylinder; ignored otherwise.</summary>
	public  void SetCylinderArcAngle(float InCylinderArcAngle) {}
	///<summary>See: bWindowFocusable</summary>
	public  bool GetWindowFocusable() { return default; }
	///<summary>See: bWindowFocusable</summary>
	public  void SetWindowFocusable(bool bInWindowFocusable) {}
	///<summary>Gets the visibility of the virtual window created to host the widget focusable.</summary>
	public  EWindowVisibility GetWindowVisiblility() { return default; }
	///<summary>Sets the visibility of the virtual window created to host the widget focusable.</summary>
	public  void SetWindowVisibility(EWindowVisibility InVisibility) {}
	///<summary>Sets the Tick mode of the Widget Component.</summary>
	public  void SetTickMode(ETickMode InTickMode) {}
	///<summary>Returns true if the the Slate window is visible and that the widget is also visible, false otherwise.</summary>
	public  bool IsWidgetVisible() { return default; }
	///<summary>The coordinate space in which to render the widget</summary>
	public EWidgetSpace Space;
	///<summary>How this widget should deal with timing, pausing, etc.</summary>
	public EWidgetTimingPolicy TimingPolicy;
	///<summary>The class of User Widget to create and display an instance of</summary>
	public UClass WidgetClass;
	///<summary>The size of the displayed quad.</summary>
	public FIntPoint DrawSize;
	///<summary>Should we wait to be told to redraw to actually draw?</summary>
	public bool bManuallyRedraw;
	///<summary>Has anyone requested we redraw?</summary>
	public bool bRedrawRequested;
	///<summary>The time in between draws, if 0 - we would redraw every frame.  If 1, we would redraw every second.</summary>
	public float RedrawTime;
	///<summary>The actual draw size, this changes based on DrawSize - or the desired size of the widget if</summary>
	public FIntPoint CurrentDrawSize;
	///<summary>Causes the render target to automatically match the desired size.</summary>
	public bool bDrawAtDesiredSize;
	///<summary>The Alignment/Pivot point that the widget is placed at relative to the position.</summary>
	public FVector2D Pivot;
	///<summary>Register with the viewport for hardware input from the true mouse and keyboard.  These widgets</summary>
	public bool bReceiveHardwareInput;
	///<summary>Is the virtual window created to host the widget focusable?</summary>
	public bool bWindowFocusable;
	///<summary>The visibility of the virtual window created to host the widget</summary>
	public EWindowVisibility WindowVisibility;
	///<summary>Widget components that appear in the world will be gamma corrected by the 3D renderer.</summary>
	public bool bApplyGammaCorrection;
	///<summary>The owner player for a widget component, if this widget is drawn on the screen, this controls</summary>
	public ULocalPlayer OwnerPlayer;
	///<summary>The background color of the component</summary>
	public FLinearColor BackgroundColor;
	///<summary>Tint color and opacity for this component</summary>
	public FLinearColor TintColorAndOpacity;
	///<summary>Sets the amount of opacity from the widget&#39;s UI texture to use when rendering the translucent or masked UI to the viewport (0.0-1.0)</summary>
	public float OpacityFromTexture;
	///<summary>The blend mode for the widget.</summary>
	public EWidgetBlendMode BlendMode;
	///<summary>Is the component visible from behind?</summary>
	public bool bIsTwoSided;
	///<summary>Should the component tick the widget when it&#39;s off screen?</summary>
	public bool TickWhenOffscreen;
	///<summary>The body setup of the displayed quad</summary>
	public UBodySetup BodySetup;
	///<summary>The material instance for translucent widget components</summary>
	public UMaterialInterface TranslucentMaterial;
	///<summary>The material instance for translucent, one-sided widget components</summary>
	public UMaterialInterface TranslucentMaterial_OneSided;
	///<summary>The material instance for opaque widget components</summary>
	public UMaterialInterface OpaqueMaterial;
	///<summary>The material instance for opaque, one-sided widget components</summary>
	public UMaterialInterface OpaqueMaterial_OneSided;
	///<summary>The material instance for masked widget components.</summary>
	public UMaterialInterface MaskedMaterial;
	///<summary>The material instance for masked, one-sided widget components.</summary>
	public UMaterialInterface MaskedMaterial_OneSided;
	///<summary>The target to which the user widget is rendered</summary>
	public UTextureRenderTarget2D RenderTarget;
	///<summary>The dynamic instance of the material that the render target is attached to</summary>
	public UMaterialInstanceDynamic MaterialInstance;
	///<summary>bAddedToScreen</summary>
	public bool bAddedToScreen;
	///<summary>Allows the widget component to be used at editor time.  For use in the VR-Editor.</summary>
	public bool bEditTimeUsable;
	///<summary>Layer Name the widget will live on</summary>
	public string SharedLayerName;
	///<summary>ZOrder the layer will be created on, note this only matters on the first time a new layer is created, subsequent additions to the same layer will use the initially defined ZOrder</summary>
	public int LayerZOrder;
	///<summary>Controls the geometry of the widget component. See EWidgetGeometryMode.</summary>
	public EWidgetGeometryMode GeometryMode;
	///<summary>Curvature of a cylindrical widget in degrees.</summary>
	public float CylinderArcAngle;
	///<summary>TickMode</summary>
	public ETickMode TickMode;
	///<summary>The User Widget object displayed and managed by this component</summary>
	public UUserWidget Widget;
}
