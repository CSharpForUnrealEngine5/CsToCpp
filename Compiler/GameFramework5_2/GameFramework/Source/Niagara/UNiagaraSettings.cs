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
	public byte DefaultRenderTargetFormat;
	public ENiagaraGpuBufferFormat DefaultGridFormat;
	public ENiagaraDefaultRendererMotionVectorSetting DefaultRendererMotionVectorSetting;
	public ENiagaraDefaultRendererPixelCoverageMode DefaultPixelCoverageMode;
	public ENiagaraDefaultSortPrecision DefaultSortPrecision;
	public ENiagaraDefaultGpuTranslucentLatency DefaultGpuTranslucentLatency;
	public float DefaultLightInverseExposureBlend;
	public byte NDISkelMesh_GpuMaxInfluences;
	public byte NDISkelMesh_GpuUniformSamplingFormat;
	public byte NDISkelMesh_AdjacencyTriangleIndexFormat;
	public bool NDIStaticMesh_AllowDistanceFields;
	public TArray<byte> NDICollisionQuery_AsyncGpuTraceProviderOrder;
	public string SimCacheAuxiliaryFileBasePath;
	public long SimCacheMaxCPUMemoryVolumetrics;
	public TArray<FNiagaraPlatformSetRedirect> PlatformSetRedirects;
}
