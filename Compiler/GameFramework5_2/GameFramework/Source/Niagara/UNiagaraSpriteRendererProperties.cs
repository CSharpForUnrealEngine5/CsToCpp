namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSpriteRendererProperties.h")]
public partial class UNiagaraSpriteRendererProperties : UNiagaraRendererProperties {
	public static UClass StaticClass() {return default;}
	///<summary>The material used to render the particle. Note that it must have the Use with Niagara Sprites flag checked.</summary>
	public UMaterialInterface Material;
	///<summary>MICMaterial</summary>
	public UMaterialInstanceConstant MICMaterial;
	///<summary>Whether or not to draw a single element for the Emitter or to draw the particles.</summary>
	public ENiagaraRendererSourceDataMode SourceMode;
	///<summary>Use the UMaterialInterface bound to this user variable if it is set to a valid value. If this is bound to a valid value and Material is also set, UserParamBinding wins.</summary>
	public FNiagaraUserParameterBinding MaterialUserParamBinding;
	///<summary>Imagine the particle texture having an arrow pointing up, these modes define how the particle aligns that texture to other particle attributes.</summary>
	public ENiagaraSpriteAlignment Alignment;
	///<summary>Determines how the particle billboard orients itself relative to the camera.</summary>
	public ENiagaraSpriteFacingMode FacingMode;
	///<summary>Determines the location of the pivot point of this particle. It follows Unreal&#39;s UV space, which has the upper left of the image at 0,0 and bottom right at 1,1. The middle is at 0.5, 0.5.</summary>
	public FVector2D PivotInUVSpace;
	///<summary>World space radius that UVs generated with the ParticleMacroUV material node will tile based on.</summary>
	public float MacroUVRadius;
	///<summary>Determines how we sort the particles prior to rendering.</summary>
	public ENiagaraSortMode SortMode;
	///<summary>When using SubImage lookups for particles, this variable contains the number of columns in X and the number of rows in Y.</summary>
	public FVector2D SubImageSize;
	///<summary>If true, blends the sub-image UV lookup with its next adjacent member using the fractional part of the SubImageIndex float value as the linear interpolation factor.</summary>
	public bool bSubImageBlend;
	///<summary>If true, removes the HMD view roll (e.g. in VR)</summary>
	public bool bRemoveHMDRollInVR;
	///<summary>If true, the particles are only sorted when using a translucent material.</summary>
	public bool bSortOnlyWhenTranslucent;
	///<summary>Sort precision to use when sorting is active.</summary>
	public ENiagaraRendererSortPrecision SortPrecision;
	///<summary>Gpu simulations run at different points in the frame depending on what features are used, i.e. depth buffer, distance fields, etc.</summary>
	public ENiagaraRendererGpuTranslucentLatency GpuTranslucentLatency;
	///<summary>This setting controls what happens when a sprite becomes less than a pixel in size.</summary>
	public ENiagaraRendererPixelCoverageMode PixelCoverageMode;
	///<summary>When pixel coverage is enabled this allows you to control the blend of the pixel coverage color adjustment.</summary>
	public float PixelCoverageBlend;
	///<summary>When FacingMode is FacingCameraDistanceBlend, the distance at which the sprite is fully facing the camera plane.</summary>
	public float MinFacingCameraBlendDistance;
	///<summary>When FacingMode is FacingCameraDistanceBlend, the distance at which the sprite is fully facing the camera position</summary>
	public float MaxFacingCameraBlendDistance;
	///<summary>Enables frustum culling of individual sprites</summary>
	public bool bEnableCameraDistanceCulling;
	///<summary>MinCameraDistance</summary>
	public float MinCameraDistance;
	///<summary>MaxCameraDistance</summary>
	public float MaxCameraDistance;
	///<summary>If a render visibility tag is present, particles whose tag matches this value will be visible in this renderer.</summary>
	public uint RendererVisibility;
	///<summary>Which attribute should we use for position when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding PositionBinding;
	///<summary>Which attribute should we use for color when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding ColorBinding;
	///<summary>Which attribute should we use for velocity when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding VelocityBinding;
	///<summary>Which attribute should we use for sprite rotation (in degrees) when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding SpriteRotationBinding;
	///<summary>Which attribute should we use for sprite size when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding SpriteSizeBinding;
	///<summary>Which attribute should we use for sprite facing when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding SpriteFacingBinding;
	///<summary>Which attribute should we use for sprite alignment when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding SpriteAlignmentBinding;
	///<summary>Which attribute should we use for sprite sub-image indexing when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding SubImageIndexBinding;
	///<summary>Which attribute should we use for dynamic material parameters when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding DynamicMaterialBinding;
	///<summary>Which attribute should we use for dynamic material parameters when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding DynamicMaterial1Binding;
	///<summary>Which attribute should we use for dynamic material parameters when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding DynamicMaterial2Binding;
	///<summary>Which attribute should we use for dynamic material parameters when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding DynamicMaterial3Binding;
	///<summary>Which attribute should we use for camera offset when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding CameraOffsetBinding;
	///<summary>Which attribute should we use for UV scale when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding UVScaleBinding;
	///<summary>Which attribute should we use for pivot offset? (NOTE: Values are expected to be in UV space).</summary>
	public FNiagaraVariableAttributeBinding PivotOffsetBinding;
	///<summary>Which attribute should we use for material randoms when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding MaterialRandomBinding;
	///<summary>Which attribute should we use for custom sorting? Defaults to Particles.NormalizedAge.</summary>
	public FNiagaraVariableAttributeBinding CustomSortingBinding;
	///<summary>Which attribute should we use for Normalized Age?</summary>
	public FNiagaraVariableAttributeBinding NormalizedAgeBinding;
	///<summary>Which attribute should we use for RendererVisibilityTag?</summary>
	public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
	///<summary>If this array has entries, we will create a MaterialInstanceDynamic per Emitter instance from Material and set the Material parameters using the Niagara simulation variables listed.</summary>
	public FNiagaraRendererMaterialParameters MaterialParameters;
	///<summary>MaterialParameterBindings_DEPRECATED</summary>
	public TArray<FNiagaraMaterialAttributeBinding> MaterialParameterBindings_DEPRECATED;
	///<summary>The following bindings are only needed for accurate motion vectors</summary>
	public FNiagaraVariableAttributeBinding PrevPositionBinding;
	///<summary>PrevVelocityBinding</summary>
	public FNiagaraVariableAttributeBinding PrevVelocityBinding;
	///<summary>PrevSpriteRotationBinding</summary>
	public FNiagaraVariableAttributeBinding PrevSpriteRotationBinding;
	///<summary>PrevSpriteSizeBinding</summary>
	public FNiagaraVariableAttributeBinding PrevSpriteSizeBinding;
	///<summary>PrevSpriteFacingBinding</summary>
	public FNiagaraVariableAttributeBinding PrevSpriteFacingBinding;
	///<summary>PrevSpriteAlignmentBinding</summary>
	public FNiagaraVariableAttributeBinding PrevSpriteAlignmentBinding;
	///<summary>PrevCameraOffsetBinding</summary>
	public FNiagaraVariableAttributeBinding PrevCameraOffsetBinding;
	///<summary>PrevPivotOffsetBinding</summary>
	public FNiagaraVariableAttributeBinding PrevPivotOffsetBinding;
	///<summary>Use the cutout texture from the material opacity mask, or if none exist, from the material opacity.</summary>
	public bool bUseMaterialCutoutTexture;
	///<summary>Texture to generate bounding geometry from.</summary>
	public UTexture2D CutoutTexture;
	///<summary>More bounding vertices results in reduced overdraw, but adds more triangle overhead.</summary>
	public ESubUVBoundingVertexCount BoundingMode;
	///<summary>OpacitySourceMode</summary>
	public EOpacitySourceMode OpacitySourceMode;
	///<summary>Alpha channel values larger than the threshold are considered occupied and will be contained in the bounding geometry.</summary>
	public float AlphaThreshold;
}
