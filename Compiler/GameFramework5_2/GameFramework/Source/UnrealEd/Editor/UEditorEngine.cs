namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/EditorEngine.h")]
public partial class UEditorEngine : UEngine {
	public static UClass StaticClass() {return default;}
	///<summary>Objects.</summary>
	public UModel TempModel;
	///<summary>ConversionTempModel</summary>
	public UModel ConversionTempModel;
	///<summary>Trans</summary>
	public UTransactor Trans;
	///<summary>Textures.</summary>
	public UTexture2D Bad;
	///<summary>Font used by Canvas-based editors</summary>
	public UFont EditorFont;
	///<summary>Audio</summary>
	public USoundCue PreviewSoundCue;
	///<summary>PreviewAudioComponent</summary>
	public UAudioComponent PreviewAudioComponent;
	///<summary>Used in UnrealEd for showing materials</summary>
	public UStaticMesh EditorCube;
	///<summary>EditorSphere</summary>
	public UStaticMesh EditorSphere;
	///<summary>EditorPlane</summary>
	public UStaticMesh EditorPlane;
	///<summary>EditorCylinder</summary>
	public UStaticMesh EditorCylinder;
	///<summary>Toggles.</summary>
	public bool bFastRebuild;
	///<summary>IsImportingT3D</summary>
	public bool IsImportingT3D;
	///<summary>Other variables.</summary>
	public uint ClickFlags;
	///<summary>ParentContext</summary>
	public UPackage ParentContext;
	///<summary>UnsnappedClickLocation</summary>
	public FVector UnsnappedClickLocation;
	///<summary>ClickLocation</summary>
	public FVector ClickLocation;
	///<summary>ClickPlane</summary>
	public FPlane ClickPlane;
	///<summary>MouseMovement</summary>
	public FVector MouseMovement;
	///<summary>Setting for the detail mode to show in the editor viewports</summary>
	public EDetailMode DetailMode;
	///<summary>Advanced.</summary>
	public bool UseSizingBox;
	///<summary>UseAxisIndicator</summary>
	public bool UseAxisIndicator;
	///<summary>GodMode</summary>
	public bool GodMode;
	///<summary>GameCommandLine</summary>
	public string GameCommandLine;
	///<summary>If true, show translucent marker polygons on the builder brush and volumes.</summary>
	public bool bShowBrushMarkerPolys;
	///<summary>If true, socket snapping is enabled in the main level viewports.</summary>
	public bool bEnableSocketSnapping;
	///<summary>If true, same type views will be camera tied, and ortho views will use perspective view for LOD parenting</summary>
	public bool bEnableLODLocking;
	///<summary>HeightMapExportClassName</summary>
	public string HeightMapExportClassName;
	///<summary>Array of actor factories created at editor startup and used by context menu etc.</summary>
	public TArray<UActorFactory> ActorFactories;
	///<summary>The name of the file currently being opened in the editor. &quot;&quot; if no file is being opened.</summary>
	public string UserOpenedFile;
	///<summary>Additional per-user/per-game options set in the .ini file. Should be in the form &quot;?option1=X?option2?option3=Y&quot;</summary>
	public string InEditorGameURLOptions;
	///<summary>A pointer to a UWorld that is the duplicated/saved-loaded to be played in with &quot;Play From Here&quot;</summary>
	public UWorld PlayWorld;
	///<summary>Has a request to toggle between PIE and SIE been made?</summary>
	public bool bIsToggleBetweenPIEandSIEQueued;
	///<summary>Allows multiple PIE worlds under a single instance. If false, you can only do multiple UE processes for pie networking</summary>
	public bool bAllowMultiplePIEWorlds;
	///<summary>True if there is a pending end play map queued</summary>
	public bool bRequestEndPlayMapQueued;
	///<summary>True if we should ignore noting any changes to selection on undo/redo</summary>
	public bool bIgnoreSelectionChange;
	///<summary>True if we should suspend notifying clients post undo/redo</summary>
	public bool bSuspendBroadcastPostUndoRedo;
	///<summary>True if we should not display notifications about undo/redo</summary>
	public bool bSquelchTransactionNotification;
	///<summary>True if we should force a selection change notification during an undo/redo</summary>
	public bool bNotifyUndoRedoSelectionChange;
	///<summary>The PlayerStart class used when spawning the player at the current camera location.</summary>
	public UClass PlayFromHerePlayerStartClass;
	///<summary>When Simulating In Editor, a pointer to the original (non-simulating) editor world</summary>
	public UWorld EditorWorld;
	///<summary>When Simulating In Editor, an array of all actors that were selected when it began</summary>
	public TArray<TWeakObjectPtr<AActor>> ActorsThatWereSelected;
	///<summary>Where did the person want to play? Where to play the game - -1 means in editor, 0 or more is an index into the GConsoleSupportContainer</summary>
	public int PlayWorldDestination;
	///<summary>The current play world destination (I.E console).  -1 means no current play world destination, 0 or more is an index into the GConsoleSupportContainer</summary>
	public int CurrentPlayWorldDestination;
	///<summary>Mobile preview settings for what orientation to default to</summary>
	public bool bMobilePreviewPortrait;
	///<summary>Currently targeted device for mobile previewer.</summary>
	public int BuildPlayDevice;
	///<summary>Play world url string edited by a user.</summary>
	public string UserEditedPlayWorldURL;
	///<summary>Temporary render target that can be used by the editor.</summary>
	public UTextureRenderTarget2D ScratchRenderTarget2048;
	///<summary>ScratchRenderTarget1024</summary>
	public UTextureRenderTarget2D ScratchRenderTarget1024;
	///<summary>ScratchRenderTarget512</summary>
	public UTextureRenderTarget2D ScratchRenderTarget512;
	///<summary>ScratchRenderTarget256</summary>
	public UTextureRenderTarget2D ScratchRenderTarget256;
	///<summary>A mesh component used to preview in editor without spawning a static mesh actor.</summary>
	public UStaticMeshComponent PreviewMeshComp;
	///<summary>The index of the mesh to use from the list of preview meshes.</summary>
	public int PreviewMeshIndex;
	///<summary>When true, the preview mesh mode is activated.</summary>
	public bool bShowPreviewMesh;
	///<summary>If &quot;Camera Align&quot; emitter handling uses a custom zoom or not</summary>
	public bool bCustomCameraAlignEmitter;
	///<summary>The distance to place the camera from an emitter actor when custom zooming is enabled</summary>
	public float CustomCameraAlignEmitterDistance;
	///<summary>If true, then draw sockets when socket snapping is enabled in &#39;g&#39; mode</summary>
	public bool bDrawSocketsInGMode;
	///<summary>If true, then draw particle debug helpers in editor viewports</summary>
	public bool bDrawParticleHelpers;
	///<summary>Brush builders that have been created in the editor</summary>
	public TArray<UBrushBuilder> BrushBuilders;
	///<summary>Manager that holds all extensions paired with a world</summary>
	public UEditorWorldExtensionManager EditorWorldExtensionsManager;
	///<summary>DragDropHandler</summary>
	public ULevelEditorDragDropHandler DragDropHandler;
	///<summary>ActorGroupingUtilsClassName</summary>
	public FSoftClassPath ActorGroupingUtilsClassName;
	///<summary>ActorGroupingUtils</summary>
	public UActorGroupingUtils ActorGroupingUtils;
	///<summary>An optional location for the starting location for &quot;Play From Here&quot;</summary>
	public FVector PlayWorldLocation;
	///<summary>An optional rotation for the starting location for &quot;Play From Here&quot;</summary>
	public FRotator PlayWorldRotation;
	///<summary>Has a request for &quot;Play From Here&quot; been made?</summary>
	public bool bIsPlayWorldQueued;
	///<summary>True if we are requesting to start a simulation-in-editor session</summary>
	public bool bIsSimulateInEditorQueued;
	///<summary>bHasPlayWorldPlacement</summary>
	public bool bHasPlayWorldPlacement;
	///<summary>bUseMobilePreviewForPlayWorld</summary>
	public bool bUseMobilePreviewForPlayWorld;
	///<summary>bUseVRPreviewForPlayWorld</summary>
	public bool bUseVRPreviewForPlayWorld;
	///<summary>True if we&#39;re Simulating In Editor, as opposed to Playing In Editor.  In this mode, simulation takes place right the level editing environment // UE_DEPRECATED(4.25, &quot;Use IsSimulateInEditorInProgress instead.&quot;)</summary>
	public bool bIsSimulatingInEditor;
	///<summary>PlayInEditorViewportIndex</summary>
	public int PlayInEditorViewportIndex;
}
