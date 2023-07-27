#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSettings.h")]
public partial class UNiagaraSettings : UDeveloperSettings {
// NiagaraSettings
	public TArray<FSoftObjectPath> AdditionalParameterTypes;
	public TArray<FSoftObjectPath> AdditionalPayloadTypes;
	public TArray<FSoftObjectPath> AdditionalParameterEnums;
	public bool bSystemViewportInOrbitMode;
	public bool bShowConvertibleInputsInStack;
	public int QuickSimCacheCaptureFrameCount;
	public bool bSystemsSupportLargeWorldCoordinates;
	public bool bEnforceStrictStackTypes;
	public bool bExperimentalVMEnabled;
	public FSoftObjectPath DefaultEffectType;
	public FLinearColor PositionPinTypeColor;
	public TArray<string> QualityLevels;
	public TMap<string,string> ComponentRendererWarningsPerClass;
	public ETextureRenderTargetFormat DefaultRenderTargetFormat;
	public ENiagaraGpuBufferFormat DefaultGridFormat;
	public ENiagaraDefaultRendererMotionVectorSetting DefaultRendererMotionVectorSetting;
	public ENiagaraDefaultRendererPixelCoverageMode DefaultPixelCoverageMode;
	public ENiagaraDefaultSortPrecision DefaultSortPrecision;
	public ENiagaraDefaultGpuTranslucentLatency DefaultGpuTranslucentLatency;
	public float DefaultLightInverseExposureBlend;
	public ENDISkelMesh_GpuMaxInfluences NDISkelMesh_GpuMaxInfluences;
	public ENDISkelMesh_GpuUniformSamplingFormat NDISkelMesh_GpuUniformSamplingFormat;
	public ENDISkelMesh_AdjacencyTriangleIndexFormat NDISkelMesh_AdjacencyTriangleIndexFormat;
	public bool NDIStaticMesh_AllowDistanceFields;
	public TArray<ENDICollisionQuery_AsyncGpuTraceProvider> NDICollisionQuery_AsyncGpuTraceProviderOrder;
	public string SimCacheAuxiliaryFileBasePath;
	public long SimCacheMaxCPUMemoryVolumetrics;
	public TArray<FNiagaraPlatformSetRedirect> PlatformSetRedirects;
}
