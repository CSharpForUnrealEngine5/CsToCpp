#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSettings.h")]
public partial class UNiagaraSettings : UDeveloperSettings {
	///<summary>AdditionalParameterTypes</summary>
	public TArray<FSoftObjectPath> AdditionalParameterTypes;
	///<summary>AdditionalPayloadTypes</summary>
	public TArray<FSoftObjectPath> AdditionalPayloadTypes;
	///<summary>AdditionalParameterEnums</summary>
	public TArray<FSoftObjectPath> AdditionalParameterEnums;
	///<summary>Sets the default navigation behavior for the system preview viewport.</summary>
	public bool bSystemViewportInOrbitMode;
	///<summary>If true then the &quot;link input&quot; menu will also show variables of different types, as long as there is a conversion script for them.</summary>
	public bool bShowConvertibleInputsInStack;
	///<summary>The number of frames to capture when capturing a Sim Cache from the Niagara Component Details Panel. *</summary>
	public int QuickSimCacheCaptureFrameCount;
	///<summary>If true then active effects rebase the simulation positions to not lose precision. Can be turned off if not needed to skip unnecessary rebasing calculations.</summary>
	public bool bSystemsSupportLargeWorldCoordinates;
	///<summary>If set to true, types like positions and vectors cannot be assigned to each other without an explicit conversion step.</summary>
	public bool bEnforceStrictStackTypes;
	///<summary>True indicates that we will generate byte code for the new experimental VM.  Control over whether the new VM will</summary>
	public bool bExperimentalVMEnabled;
	///<summary>Default effect type to use for effects that don&#39;t define their own. Can be null.</summary>
	public FSoftObjectPath DefaultEffectType;
	///<summary>Position pin type color. The other pin colors are defined in the general editor settings.</summary>
	public FLinearColor PositionPinTypeColor;
	///<summary>The quality levels Niagara uses.</summary>
	public TArray<string> QualityLevels;
	///<summary>Info texts that the component renderer shows the user depending on the selected component class.</summary>
	public TMap<string,string> ComponentRendererWarningsPerClass;
	///<summary>The default render target format used by all Niagara Render Target Data Interfaces unless overridden.</summary>
	public ETextureRenderTargetFormat DefaultRenderTargetFormat;
	///<summary>The default buffer format used by all Niagara Grid Data Interfaces unless overridden.</summary>
	public ENiagaraGpuBufferFormat DefaultGridFormat;
	///<summary>The default setting for motion vectors in Niagara renderers</summary>
	public ENiagaraDefaultRendererMotionVectorSetting DefaultRendererMotionVectorSetting;
	///<summary>The default setting for pixel coverage mode when automatic is set on the Niagara Renderer.</summary>
	public ENiagaraDefaultRendererPixelCoverageMode DefaultPixelCoverageMode;
	///<summary>The default setting for sorting precision when automatic is set on the Niagara Renderer.</summary>
	public ENiagaraDefaultSortPrecision DefaultSortPrecision;
	///<summary>The default setting for Gpu simulation translucent draw latency.</summary>
	public ENiagaraDefaultGpuTranslucentLatency DefaultGpuTranslucentLatency;
	///<summary>The default InverseExposureBlend used for the light renderer.</summary>
	public float DefaultLightInverseExposureBlend;
	///<summary>Controls the maximum number of influences we allow the Skeletal Mesh Data Interface to use on the GPU.  Changing this setting requires restarting the editor.</summary>
	public ENDISkelMesh_GpuMaxInfluences NDISkelMesh_GpuMaxInfluences;
	///<summary>Controls the format used for uniform sampling on the GPU.  Changing this setting requires restarting the editor.</summary>
	public ENDISkelMesh_GpuUniformSamplingFormat NDISkelMesh_GpuUniformSamplingFormat;
	///<summary>Controls the format used for specifying triangle indexes in adjacency buffers.  Changing this setting requires restarting the editor.</summary>
	public ENDISkelMesh_AdjacencyTriangleIndexFormat NDISkelMesh_AdjacencyTriangleIndexFormat;
	///<summary>When enabled the static mesh data interface is allowed to sample from the distance field data (if present) on the GPU.</summary>
	public bool NDIStaticMesh_AllowDistanceFields;
	///<summary>Defines how traces tagged as &#39;Project Default&#39; will be interpreted when using the AsyncGpuTrace data interface.</summary>
	public TArray<ENDICollisionQuery_AsyncGpuTraceProvider> NDICollisionQuery_AsyncGpuTraceProviderOrder;
	///<summary>Base path for auxiliary files written out during the generation of a Niagara Sim Cache (ie: volume files).</summary>
	public string SimCacheAuxiliaryFileBasePath;
	///<summary>Max memory in megabytes for total CPU memory for cached volumetric data</summary>
	public long SimCacheMaxCPUMemoryVolumetrics;
	///<summary>PlatformSetRedirects</summary>
	public TArray<FNiagaraPlatformSetRedirect> PlatformSetRedirects;
}
