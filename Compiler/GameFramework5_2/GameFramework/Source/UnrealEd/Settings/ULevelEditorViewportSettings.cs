#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Level Editor&#39;s view port settings.</summary>
[CppInclude("Settings/LevelEditorViewportSettings.h")]
public partial class ULevelEditorViewportSettings : UObject {
	///<summary>Enable the use of flight camera controls under various circumstances.</summary>
	public EWASDType FlightCameraControlType;
	///<summary>Enable the use of the experimental navigation in the flight camera controls.</summary>
	public bool FlightCameraControlExperimentalNavigation;
	///<summary>Choose the control scheme for landscape tools (ignored for pen input)</summary>
	public ELandscapeFoliageEditorControlType LandscapeEditorControlType;
	///<summary>Choose the control scheme for foliage tools</summary>
	public ELandscapeFoliageEditorControlType FoliageEditorControlType;
	///<summary>If true, moves the canvas and shows the mouse.  If false, uses original camera movement.</summary>
	public bool bPanMovesCanvas;
	///<summary>If checked, in orthographic view ports zooming will center on the mouse position.  If unchecked, the zoom is around the center of the viewport.</summary>
	public bool bCenterZoomAroundCursor;
	///<summary>The closest possible distance allowed when viewing through an orthographic camera</summary>
	public float MinimumOrthographicZoom;
	///<summary>Allow translate/rotate widget</summary>
	public bool bAllowTranslateRotateZWidget;
	///<summary>Allow arcball rotation with rotate widget</summary>
	public bool bAllowArcballRotate;
	///<summary>Allow screen rotation with rotate widget</summary>
	public bool bAllowScreenRotate;
	///<summary>If true, Clicking a BSP selects the brush and ctrl+shift+click selects the surface. If false, vice versa</summary>
	public bool bClickBSPSelectsBrush;
	///<summary>If true, viewport will show actor editor context (current level, current data layer(s), current folder)</summary>
	public bool bShowActorEditorContext;
	///<summary>How fast the perspective camera moves when flying through the world.</summary>
	public int CameraSpeed;
	///<summary>Scalar applied to perspective camera movement to increase movement range.</summary>
	public float CameraSpeedScalar;
	///<summary>How fast the perspective camera moves through the world when using mouse scroll.</summary>
	public int MouseScrollCameraSpeed;
	///<summary>The sensitivity of mouse movement when rotating the camera.</summary>
	public float MouseSensitivty;
	///<summary>Whether or not to invert mouse on the y axis in free look mode</summary>
	public bool bInvertMouseLookYAxis;
	///<summary>Whether or not to invert mouse on y axis in orbit mode</summary>
	public bool bInvertOrbitYAxis;
	///<summary>Whether or not to invert the direction of middle mouse panning in viewports</summary>
	public bool bInvertMiddleMousePan;
	///<summary>Whether or not to invert the direction of right mouse dolly on the Y axis in orbit mode</summary>
	public bool bInvertRightMouseDollyYAxis;
	///<summary>Whether to use mouse position as direct widget position.</summary>
	public bool bUseAbsoluteTranslation;
	///<summary>If enabled, the viewport will stream in levels automatically when the camera is moved.</summary>
	public bool bLevelStreamingVolumePrevis;
	///<summary>When checked, orbit the camera by using the L or U keys when unchecked, Alt and Left Mouse Drag will orbit around the look at point</summary>
	public bool bUseUE3OrbitControls;
	///<summary>Direction of the scroll gesture for 3D viewports</summary>
	public EScrollGestureDirection ScrollGestureDirectionFor3DViewports;
	///<summary>Direction of the scroll gesture for orthographic viewports</summary>
	public EScrollGestureDirection ScrollGestureDirectionForOrthoViewports;
	///<summary>Enables joystick-based camera movement in 3D level editing viewports</summary>
	public bool bLevelEditorJoystickControls;
	///<summary>If enabled, scale the perspective camera speed based on the distance between the camera and its look-at position</summary>
	public bool bUseDistanceScaledCameraSpeed;
	///<summary>If enabled, the camera will orbit around the current selection in the viewport</summary>
	public bool bOrbitCameraAroundSelection;
	///<summary>If enabled will use power of 2 grid settings (e.g, 1,2,4,8,16,...,1024) instead of decimal grid sizes</summary>
	public bool bUsePowerOf2SnapSize;
	///<summary>Decimal grid sizes (for translation snapping and grid rendering)</summary>
	public TArray<float> DecimalGridSizes;
	///<summary>The number of lines between each major line interval for decimal grids</summary>
	public TArray<float> DecimalGridIntervals;
	///<summary>Power of 2 grid sizes (for translation snapping and grid rendering)</summary>
	public TArray<float> Pow2GridSizes;
	///<summary>The number of lines between each major line interval for pow2 grids</summary>
	public TArray<float> Pow2GridIntervals;
	///<summary>User defined grid intervals for rotations</summary>
	public TArray<float> CommonRotGridSizes;
	///<summary>Preset grid intervals for rotations</summary>
	public TArray<float> DivisionsOf360RotGridSizes;
	///<summary>Grid sizes for scaling</summary>
	public TArray<float> ScalingGridSizes;
	///<summary>If enabled, actor positions will snap to the grid.</summary>
	public bool GridEnabled;
	///<summary>If enabled, actor rotations will snap to the grid.</summary>
	public bool RotGridEnabled;
	///<summary>If enabled, actor sizes will snap to the grid.</summary>
	public bool SnapScaleEnabled;
	///<summary>If enabled, actors will snap to surfaces in the viewport when dragged around</summary>
	public FSnapToSurfaceSettings SnapToSurface;
	///<summary>If enabled, use the old-style multiplicative/percentage scaling method instead of the new additive/fraction method</summary>
	public bool bUsePercentageBasedScaling;
	///<summary>If enabled, new Actors that you drag into the viewport snap to the active 2D layer.</summary>
	public bool bEnableLayerSnap;
	///<summary>The index of the snap plane to use when 2D Layer Snapping is enabled, from the array of Snap Layers set for the project.</summary>
	public int ActiveSnapLayerIndex;
	///<summary>If true actor snap will be enabled in the editor *</summary>
	public bool bEnableActorSnap;
	///<summary>Global actor snap scale for the editor</summary>
	public float ActorSnapScale;
	///<summary>Global actor snap distance setting for the editor</summary>
	public float ActorSnapDistance;
	///<summary>bSnapVertices</summary>
	public bool bSnapVertices;
	///<summary>SnapDistance</summary>
	public float SnapDistance;
	///<summary>CurrentPosGridSize</summary>
	public int CurrentPosGridSize;
	///<summary>CurrentRotGridSize</summary>
	public int CurrentRotGridSize;
	///<summary>CurrentScalingGridSize</summary>
	public int CurrentScalingGridSize;
	///<summary>PreserveNonUniformScale</summary>
	public bool PreserveNonUniformScale;
	///<summary>Controls which array of rotation grid values we are using</summary>
	public ERotationGridMode CurrentRotGridMode;
	///<summary>How to constrain perspective view port FOV</summary>
	public EAspectRatioAxisConstraint AspectRatioAxisConstraint;
	///<summary>Enables real-time hover feedback when mousing over objects in editor view ports</summary>
	public bool bEnableViewportHoverFeedback;
	///<summary>If enabled, selected objects will be highlighted with brackets in all modes rather than a special highlight color.</summary>
	public bool bHighlightWithBrackets;
	///<summary>If checked all orthographic view ports are linked to the same position and move together.</summary>
	public bool bUseLinkedOrthographicViewports;
	///<summary>True if viewport box selection requires objects to be fully encompassed by the selection box to be selected</summary>
	public bool bStrictBoxSelection;
	///<summary>True if viewport box selection also selects occluded objects, false if only objects with visible pixels are selected</summary>
	public bool bTransparentBoxSelection;
	///<summary>Whether to show selection outlines for selected Actors</summary>
	public bool bUseSelectionOutline;
	///<summary>Sets the intensity of the overlay displayed when an object is selected</summary>
	public float SelectionHighlightIntensity;
	///<summary>Sets the intensity of the overlay displayed when an object is selected</summary>
	public float BSPSelectionHighlightIntensity;
	///<summary>Enables the editor perspective camera to be dropped at the last PlayInViewport cam position</summary>
	public bool bEnableViewportCameraToUpdateFromPIV;
	///<summary>When enabled, selecting a camera actor will display a live &#39;picture in picture&#39; preview from the camera&#39;s perspective within the current editor view port.  This can be used to easily tweak camera positioning, post-processing and other settings without having to possess the camera itself.  This feature may reduce application performance when enabled.</summary>
	public bool bPreviewSelectedCameras;
	///<summary>Affects the size of &#39;picture in picture&#39; previews if they are enabled</summary>
	public float CameraPreviewSize;
	///<summary>Distance from the camera to place actors which are dropped on nothing in the view port.</summary>
	public float BackgroundDropDistance;
	///<summary>A list of meshes that can be used as preview mesh in the editor view port by holding down the backslash key</summary>
	public TArray<FSoftObjectPath> PreviewMeshes;
	///<summary>BillboardScale</summary>
	public float BillboardScale;
	///<summary>The size adjustment to apply to the translate/rotate/scale widgets (in Unreal units).</summary>
	public int TransformWidgetSizeAdjustment;
	///<summary>When enabled, engine stats that are enabled in level viewports are preserved between editor sessions</summary>
	public bool bSaveEngineStats;
	///<summary>Specify the units used by the measuring tool</summary>
	public EMeasuringToolUnits MeasuringToolUnits;
	///<summary>The size adjustment to apply to selected spline points (in screen space units).</summary>
	public float SelectedSplinePointSizeAdjustment;
	///<summary>The size adjustment to apply to spline line thickness which increases the spline&#39;s hit tolerance.</summary>
	public float SplineLineThicknessAdjustment;
	///<summary>The size adjustment to apply to spline tangent handle (in screen space units).</summary>
	public float SplineTangentHandleSizeAdjustment;
	///<summary>The scale to apply to spline tangent lengths</summary>
	public float SplineTangentScale;
	///<summary>LastInViewportMenuLocation</summary>
	public FVector2D LastInViewportMenuLocation;
	///<summary>When dropping a texture in the viewport, create an instance of this material instead of creating a new material. Populate MaterialParamsForDroppedTextures to specify the parameter names.</summary>
	public TSoftObjectPtr<UMaterialInterface> MaterialForDroppedTextures;
	///<summary>When dropping a texture in the viewport, determines which material parameter to assign for each found texture type. Only relevant if MaterialForDroppedTextures is assigned.</summary>
	public TMap<EMaterialKind,string> MaterialParamsForDroppedTextures;
	///<summary>Per-instance viewport settings.</summary>
	public TArray<FLevelEditorViewportInstanceSettingsKeyValuePair> PerInstanceSettings;
}
