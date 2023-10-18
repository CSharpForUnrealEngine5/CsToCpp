namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraMeshRendererProperties.h")]
public partial class UNiagaraMeshRendererProperties : UNiagaraRendererProperties {
	public static UClass StaticClass() {return default;}
	///<summary>The static mesh(es) to be instanced when rendering mesh particles.</summary>
	public TArray<FNiagaraMeshRendererMeshProperties> Meshes;
	///<summary>Whether or not to draw a single element for the Emitter or to draw the particles.</summary>
	public ENiagaraRendererSourceDataMode SourceMode;
	///<summary>Determines how we sort the particles prior to rendering.</summary>
	public ENiagaraSortMode SortMode;
	///<summary>Sort precision to use when sorting is active.</summary>
	public ENiagaraRendererSortPrecision SortPrecision;
	///<summary>Gpu simulations run at different points in the frame depending on what features are used, i.e. depth buffer, distance fields, etc.</summary>
	public ENiagaraRendererGpuTranslucentLatency GpuTranslucentLatency;
	///<summary>Whether or not to use the OverrideMaterials array instead of the mesh&#39;s existing materials.</summary>
	public bool bOverrideMaterials;
	///<summary>Whether or not to render with heterogeneous volumes.</summary>
	public bool bUseHeterogeneousVolumes;
	///<summary>If true, the particles are only sorted when using a translucent material.</summary>
	public bool bSortOnlyWhenTranslucent;
	///<summary>If true, blends the sub-image UV lookup with its next adjacent member using the fractional part of the SubImageIndex float value as the linear interpolation factor.</summary>
	public bool bSubImageBlend;
	///<summary>Enables frustum culling of individual mesh particles</summary>
	public bool bEnableFrustumCulling;
	///<summary>Enables frustum culling of individual mesh particles</summary>
	public bool bEnableCameraDistanceCulling;
	///<summary>When checked, will treat &#39;ParticleMesh&#39; as the first frame of the flipbook, and will use the other mesh flipbook options to find the other frames</summary>
	public bool bEnableMeshFlipbook;
	///<summary>If true and in a non-default facing mode, will lock facing direction to an arbitrary plane of rotation</summary>
	public bool bLockedAxisEnable;
	///<summary>The materials to be used instead of the StaticMesh&#39;s materials. Note that each material must have the Niagara Mesh Particles flag checked. If the ParticleMesh</summary>
	public TArray<FNiagaraMeshMaterialOverride> OverrideMaterials;
	///<summary>MICOverrideMaterials</summary>
	public TArray<FNiagaraMeshMICOverride> MICOverrideMaterials;
	///<summary>When using SubImage lookups for particles, this variable contains the number of columns in X and the number of rows in Y.</summary>
	public FVector2D SubImageSize;
	///<summary>Arbitrary axis by which to lock facing rotations</summary>
	public FVector LockedAxis;
	///<summary>Scale factor applied to all of the meshes bounds.</summary>
	public FVector MeshBoundsScale;
	///<summary>Determines how the mesh orients itself relative to the camera.</summary>
	public ENiagaraMeshFacingMode FacingMode;
	///<summary>Specifies what space the locked axis is in</summary>
	public ENiagaraMeshLockedAxisSpace LockedAxisSpace;
	///<summary>MinCameraDistance</summary>
	public float MinCameraDistance;
	///<summary>MaxCameraDistance</summary>
	public float MaxCameraDistance;
	///<summary>If a render visibility tag is present, particles whose tag matches this value will be visible in this renderer.</summary>
	public uint RendererVisibility;
	///<summary>Which attribute should we use for position when generating instanced meshes?</summary>
	public FNiagaraVariableAttributeBinding PositionBinding;
	///<summary>Which attribute should we use for color when generating instanced meshes?</summary>
	public FNiagaraVariableAttributeBinding ColorBinding;
	///<summary>Which attribute should we use for velocity when generating instanced meshes?</summary>
	public FNiagaraVariableAttributeBinding VelocityBinding;
	///<summary>Which attribute should we use for orienting meshes when generating instanced meshes?</summary>
	public FNiagaraVariableAttributeBinding MeshOrientationBinding;
	///<summary>Which attribute should we use for scale when generating instanced meshes?</summary>
	public FNiagaraVariableAttributeBinding ScaleBinding;
	///<summary>Which attribute should we use for sprite sub-image indexing when generating sprites?</summary>
	public FNiagaraVariableAttributeBinding SubImageIndexBinding;
	///<summary>Which attribute should we use for dynamic material parameters when generating instanced meshes?</summary>
	public FNiagaraVariableAttributeBinding DynamicMaterialBinding;
	///<summary>Which attribute should we use for dynamic material parameters when generating instanced meshes?</summary>
	public FNiagaraVariableAttributeBinding DynamicMaterial1Binding;
	///<summary>Which attribute should we use for dynamic material parameters when generating instanced meshes?</summary>
	public FNiagaraVariableAttributeBinding DynamicMaterial2Binding;
	///<summary>Which attribute should we use for dynamic material parameters when generating instanced meshes?</summary>
	public FNiagaraVariableAttributeBinding DynamicMaterial3Binding;
	///<summary>Which attribute should we use for material randoms when generating instanced meshes?</summary>
	public FNiagaraVariableAttributeBinding MaterialRandomBinding;
	///<summary>Which attribute should we use custom sorting of particles in this emitter.</summary>
	public FNiagaraVariableAttributeBinding CustomSortingBinding;
	///<summary>Which attribute should we use for Normalized Age?</summary>
	public FNiagaraVariableAttributeBinding NormalizedAgeBinding;
	///<summary>Which attribute should we use for camera offset when rendering meshes?</summary>
	public FNiagaraVariableAttributeBinding CameraOffsetBinding;
	///<summary>Which attribute should we use for the renderer visibility tag?</summary>
	public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
	///<summary>Which attribute should we use to pick the element in the mesh array on the mesh renderer?</summary>
	public FNiagaraVariableAttributeBinding MeshIndexBinding;
	///<summary>If this array has entries, we will create a MaterialInstanceDynamic per Emitter instance from Material and set the Material parameters using the Niagara simulation variables listed.</summary>
	public FNiagaraRendererMaterialParameters MaterialParameters;
	///<summary>MaterialParameterBindings_DEPRECATED</summary>
	public TArray<FNiagaraMaterialAttributeBinding> MaterialParameterBindings_DEPRECATED;
	///<summary>The following bindings are not provided by the user, but are filled based on what other bindings are set to, and the value of bGenerateAccurateMotionVectors</summary>
	public FNiagaraVariableAttributeBinding PrevPositionBinding;
	///<summary>PrevScaleBinding</summary>
	public FNiagaraVariableAttributeBinding PrevScaleBinding;
	///<summary>PrevMeshOrientationBinding</summary>
	public FNiagaraVariableAttributeBinding PrevMeshOrientationBinding;
	///<summary>PrevCameraOffsetBinding</summary>
	public FNiagaraVariableAttributeBinding PrevCameraOffsetBinding;
	///<summary>PrevVelocityBinding</summary>
	public FNiagaraVariableAttributeBinding PrevVelocityBinding;
	///<summary>The static mesh to use for the first frame of the flipbook. Its name will also be used to find subsequent frames of a similar name.</summary>
	public UStaticMesh FirstFlipbookFrame;
	///<summary>Provides the format of the suffix of the names of the static meshes when searching for flipbook frames. &quot;{frame_number}&quot; is used to mark</summary>
	public string FlipbookSuffixFormat;
	///<summary>The number of digits to expect in the frame number of the flipbook page. A value of 1 will expect no leading zeros in the package names,</summary>
	public uint FlipbookSuffixNumDigits;
	///<summary>The number of frames (static meshes) to be included in the flipbook.</summary>
	public uint NumFlipbookFrames;
	///<summary>MaterialParamValidMask</summary>
	public uint MaterialParamValidMask;
	///<summary>These properties are deprecated and moved to FNiagaraMeshRendererMeshProperties</summary>
	public UStaticMesh ParticleMesh_DEPRECATED;
	///<summary>PivotOffset_DEPRECATED</summary>
	public FVector PivotOffset_DEPRECATED;
	///<summary>PivotOffsetSpace_DEPRECATED</summary>
	public ENiagaraMeshPivotOffsetSpace PivotOffsetSpace_DEPRECATED;
}
