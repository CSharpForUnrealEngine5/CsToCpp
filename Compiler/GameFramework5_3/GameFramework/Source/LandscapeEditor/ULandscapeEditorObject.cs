namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeEditorObject.h")]
public partial class ULandscapeEditorObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Strength of the Sculpt tool. If you&#39;re using a pen/tablet with pressure-sensing, the pressure used affects the strength of the tool.</summary>
	public float ToolStrength;
	///<summary>Strength of the Paint tool. If you&#39;re using a pen/tablet with pressure-sensing, the pressure used affects the strength of the tool.</summary>
	public float PaintToolStrength;
	///<summary>Enable to make tools blend towards a target value</summary>
	public bool bUseWeightTargetValue;
	///<summary>Enable to make tools blend towards a target value</summary>
	public float WeightTargetValue;
	///<summary>I have no idea what this is for but it&#39;s used by the noise and erosion tools, and isn&#39;t exposed to the UI</summary>
	public float MaximumValueRadius;
	///<summary>bCombinedLayersOperation</summary>
	public bool bCombinedLayersOperation;
	///<summary>Whether to flatten by lowering, raising, both or terracing</summary>
	public ELandscapeToolFlattenMode FlattenMode;
	///<summary>Flattens to the angle of the clicked point, instead of horizontal</summary>
	public bool bUseSlopeFlatten;
	///<summary>Constantly picks new values to flatten towards when dragging around, instead of only using the first clicked point</summary>
	public bool bPickValuePerApply;
	///<summary>Enable to flatten towards a target height</summary>
	public bool bUseFlattenTarget;
	///<summary>Target height to flatten towards (in Unreal Units)</summary>
	public float FlattenTarget;
	///<summary>Whether to show the preview grid for the flatten target height</summary>
	public bool bShowFlattenTargetPreview;
	///<summary>Height of the terrace intervals in unreal units, for the terrace flatten mode</summary>
	public float TerraceInterval;
	///<summary>Smoothing value for terrace flatten mode</summary>
	public float TerraceSmooth;
	///<summary>Whether the Eye Dropper mode is activated</summary>
	public bool bFlattenEyeDropperModeActivated;
	///<summary>FlattenEyeDropperModeDesiredTarget</summary>
	public float FlattenEyeDropperModeDesiredTarget;
	///<summary>Width of ramp</summary>
	public float RampWidth;
	///<summary>Falloff on side of ramp</summary>
	public float RampSideFalloff;
	///<summary>The radius smoothing is performed over</summary>
	public int SmoothFilterKernelSize;
	///<summary>If checked, performs a detail preserving smooth using the specified detail smoothing value</summary>
	public bool bDetailSmooth;
	///<summary>Larger detail smoothing values remove more details, while smaller values preserve more details</summary>
	public float DetailScale;
	///<summary>The minimum height difference necessary for the erosion effects to be applied. Smaller values will result in more erosion being applied</summary>
	public int ErodeThresh;
	///<summary>The thickness of the surface for the layer weight erosion effect</summary>
	public int ErodeSurfaceThickness;
	///<summary>Number of erosion iterations, more means more erosion but is slower</summary>
	public int ErodeIterationNum;
	///<summary>Whether to erode by lowering, raising, or both</summary>
	public ELandscapeToolErosionMode ErosionNoiseMode;
	///<summary>The size of the perlin noise filter used</summary>
	public float ErosionNoiseScale;
	///<summary>The amount of rain to apply to the surface. Larger values will result in more erosion</summary>
	public int RainAmount;
	///<summary>The amount of sediment that the water can carry. Larger values will result in more erosion</summary>
	public float SedimentCapacity;
	///<summary>Number of erosion iterations, more means more erosion but is slower</summary>
	public int HErodeIterationNum;
	///<summary>Initial Rain Distribution</summary>
	public ELandscapeToolHydroErosionMode RainDistMode;
	///<summary>The size of the noise filter for applying initial rain to the surface</summary>
	public float RainDistScale;
	///<summary>If checked, performs a detail-preserving smooth to the erosion effect using the specified detail smoothing value</summary>
	public bool bHErosionDetailSmooth;
	///<summary>Larger detail smoothing values remove more details, while smaller values preserve more details</summary>
	public float HErosionDetailScale;
	///<summary>Whether to apply noise that raises, lowers, or both</summary>
	public ELandscapeToolNoiseMode NoiseMode;
	///<summary>The size of the perlin noise filter used</summary>
	public float NoiseScale;
	///<summary>Uses selected region as a mask for other tools</summary>
	public bool bUseSelectedRegion;
	///<summary>If enabled, protects the selected region from changes</summary>
	public bool bUseNegativeMask;
	///<summary>Whether to paste will only raise, only lower, or both</summary>
	public ELandscapeToolPasteMode PasteMode;
	///<summary>If set, copies/pastes all layers, otherwise only copy/pastes the layer selected in the targets panel</summary>
	public bool bApplyToAllTargets;
	///<summary>SnapMode</summary>
	public ELandscapeGizmoSnapType SnapMode;
	///<summary>Smooths the edges of the gizmo data into the landscape. Without this, the edges of the pasted data will be sharp</summary>
	public bool bSmoothGizmoBrush;
	///<summary>GizmoHeightmapFilenameString</summary>
	public string GizmoHeightmapFilenameString;
	///<summary>GizmoImportSize</summary>
	public FIntPoint GizmoImportSize;
	///<summary>GizmoImportLayers</summary>
	public TArray<FGizmoImportLayer> GizmoImportLayers;
	///<summary>Location of the mirror plane, defaults to the center of the landscape. Doesn&#39;t normally need to be changed!</summary>
	public FVector2D MirrorPoint;
	///<summary>Type of mirroring operation to perform e.g. &quot;Minus X To Plus X&quot; copies and flips the -X half of the landscape onto the +X half</summary>
	public ELandscapeMirrorOperation MirrorOp;
	///<summary>Number of vertices either side of the mirror plane to smooth over</summary>
	public int MirrorSmoothingWidth;
	///<summary>Blueprint Brush Tool</summary>
	public UClass BlueprintBrush;
	///<summary>Number of quads per landscape component section</summary>
	public int ResizeLandscape_QuadsPerSection;
	///<summary>Number of sections per landscape component</summary>
	public int ResizeLandscape_SectionsPerComponent;
	///<summary>Number of components in resulting landscape</summary>
	public FIntPoint ResizeLandscape_ComponentCount;
	///<summary>Determines how the new component size will be applied to the existing landscape geometry.</summary>
	public ELandscapeConvertMode ResizeLandscape_ConvertMode;
	///<summary>Material initially applied to the landscape. Setting a material here exposes properties for setting up layer info based on the landscape blend nodes in the material.</summary>
	public TWeakObjectPtr<UMaterialInterface> NewLandscape_Material;
	///<summary>The number of quads in a single landscape section. One section is the unit of LOD transition for landscape rendering.</summary>
	public int NewLandscape_QuadsPerSection;
	///<summary>The number of sections in a single landscape component. This along with the section size determines the size of each landscape component. A component is the base unit of rendering and culling.</summary>
	public int NewLandscape_SectionsPerComponent;
	///<summary>The number of components in the X and Y direction, determining the overall size of the landscape.</summary>
	public FIntPoint NewLandscape_ComponentCount;
	///<summary>The location of the new landscape</summary>
	public FVector NewLandscape_Location;
	///<summary>The rotation of the new landscape</summary>
	public FRotator NewLandscape_Rotation;
	///<summary>The scale of the new landscape. This is the distance between each vertex on the landscape, defaulting to 100 units.</summary>
	public FVector NewLandscape_Scale;
	///<summary>ImportLandscape_HeightmapImportResult</summary>
	public ELandscapeImportResult ImportLandscape_HeightmapImportResult;
	///<summary>ImportLandscape_HeightmapErrorMessage</summary>
	public FText ImportLandscape_HeightmapErrorMessage;
	///<summary>Specify a height map file in 16-bit RAW or PNG format</summary>
	public string ImportLandscape_HeightmapFilename;
	///<summary>ImportLandscape_Width</summary>
	public uint ImportLandscape_Width;
	///<summary>ImportLandscape_Height</summary>
	public uint ImportLandscape_Height;
	///<summary>HeightmapExportFilename</summary>
	public string HeightmapExportFilename;
	///<summary>ImportLandscape_GizmoLocalPosition</summary>
	public FIntPoint ImportLandscape_GizmoLocalPosition;
	///<summary>ImportType</summary>
	public ELandscapeImportTransformType ImportType;
	///<summary>bHeightmapSelected</summary>
	public bool bHeightmapSelected;
	///<summary>When true exports the selected edit layer, if false exports the blended result</summary>
	public bool bExportEditLayer;
	///<summary>(World Partition only) When true, exports the landscape as a single file, if false exports each grid tile individually.</summary>
	public bool bExportSingleFile;
	///<summary>Import Loaded or All Landscape Regions</summary>
	public ELandscapeImportExportMode ImportExportMode;
	///<summary>HeightmapImportDescriptor</summary>
	public FLandscapeImportDescriptor HeightmapImportDescriptor;
	///<summary>HeightmapImportDescriptorIndex</summary>
	public int HeightmapImportDescriptorIndex;
	///<summary>ImportLandscape_Data</summary>
	public TArray<ushort> ImportLandscape_Data;
	///<summary>Enable support for landscape edit layers.</summary>
	public bool bCanHaveLayersContent;
	///<summary>Whether to flip Y coordinate of imported files.</summary>
	public bool bFlipYAxis;
	///<summary>Number of components per landscape streaming proxies per axis</summary>
	public uint WorldPartitionGridSize;
	///<summary>Number of components per Landscape World Partition Region per axis.</summary>
	public uint WorldPartitionRegionSize;
	///<summary>Whether the imported alpha maps are to be interpreted as &quot;layered&quot; or &quot;additive&quot; (UE uses additive internally)</summary>
	public ELandscapeImportAlphamapType ImportLandscape_AlphamapType;
	///<summary>The landscape layers that will be created. Only layer names referenced in the material assigned above are shown here. Modify the material to add more layers.</summary>
	public TArray<FLandscapeImportLayer> ImportLandscape_Layers;
	///<summary>The radius of the sculpt brush, in unreal units</summary>
	public float BrushRadius;
	///<summary>The radius of the paint brush, in unreal units</summary>
	public float PaintBrushRadius;
	///<summary>The falloff at the edge of the sculpt brush, as a fraction of the brush&#39;s size. 0 = no falloff, 1 = all falloff</summary>
	public float BrushFalloff;
	///<summary>The falloff at the edge of the point brush, as a fraction of the brush&#39;s size. 0 = no falloff, 1 = all falloff</summary>
	public float PaintBrushFalloff;
	///<summary>Selects the Clay Brush painting mode</summary>
	public bool bUseClayBrush;
	///<summary>Scale of the brush texture. A scale of 1.000 maps the brush texture to the landscape at a 1 pixel = 1 vertex size</summary>
	public float AlphaBrushScale;
	///<summary>Rotate brush to follow mouse</summary>
	public bool bAlphaBrushAutoRotate;
	///<summary>Rotates the brush mask texture</summary>
	public float AlphaBrushRotation;
	///<summary>Horizontally offsets the brush mask texture</summary>
	public float AlphaBrushPanU;
	///<summary>Vertically offsets the brush mask texture</summary>
	public float AlphaBrushPanV;
	///<summary>bUseWorldSpacePatternBrush</summary>
	public bool bUseWorldSpacePatternBrush;
	///<summary>WorldSpacePatternBrushSettings</summary>
	public FLandscapePatternBrushWorldSpaceSettings WorldSpacePatternBrushSettings;
	///<summary>Mask texture to use</summary>
	public UTexture2D AlphaTexture;
	///<summary>Channel of Mask Texture to use</summary>
	public ELandscapeTextureColorChannel AlphaTextureChannel;
	///<summary>AlphaTextureSizeX</summary>
	public int AlphaTextureSizeX;
	///<summary>AlphaTextureSizeY</summary>
	public int AlphaTextureSizeY;
	///<summary>AlphaTextureData</summary>
	public TArray<byte> AlphaTextureData;
	///<summary>Number of components X/Y to affect at once. 1 means 1x1, 2 means 2x2, etc</summary>
	public int BrushComponentSize;
	///<summary>When true, the brush will affect all pixels within the component, including those on the border, which means neightboring components (which share a line/row with their neighbor) will be affected as well</summary>
	public bool bBrushComponentIncludeBorder;
	///<summary>Limits painting to only the components that already have the selected layer</summary>
	public ELandscapeLayerPaintingRestriction PaintingRestriction;
	///<summary>Display order of the targets</summary>
	public ELandscapeLayerDisplayMode TargetDisplayOrder;
	///<summary>ShowUnusedLayers</summary>
	public bool ShowUnusedLayers;
	///<summary>CurrentLayerIndex</summary>
	public int CurrentLayerIndex;
}
