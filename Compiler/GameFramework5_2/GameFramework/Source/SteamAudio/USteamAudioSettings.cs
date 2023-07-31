#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SteamAudioSettings.h")]
public partial class USteamAudioSettings : UObject {
	///<summary>OutputSubmix</summary>
	public FSoftObjectPath OutputSubmix;
	///<summary>Which audio engine to use.</summary>
	public EIplAudioEngine AudioEngine;
	///<summary>Which ray tracer type to use.</summary>
	public EIplRayTracerType RayTracer;
	///<summary>Which convolution renderer to use.</summary>
	public EIplConvolutionType ConvolutionType;
	///<summary>Whether or not to export BSP geometry.</summary>
	public bool ExportBSPGeometry;
	///<summary>Whether or not to export Landscape geometry.</summary>
	public bool ExportLandscapeGeometry;
	///<summary>Preset material settings for Static Mesh actors.</summary>
	public EPhononMaterial StaticMeshMaterialPreset;
	///<summary>How much this material absorbs low frequency sound.</summary>
	public float StaticMeshLowFreqAbsorption;
	///<summary>How much this material absorbs mid frequency sound.</summary>
	public float StaticMeshMidFreqAbsorption;
	///<summary>How much this material absorbs high frequency sound.</summary>
	public float StaticMeshHighFreqAbsorption;
	///<summary>How much this material transmits low frequency sound.</summary>
	public float StaticMeshLowFreqTransmission;
	///<summary>How much this material transmits mid frequency sound.</summary>
	public float StaticMeshMidFreqTransmission;
	///<summary>How much this material transmits high frequency sound.</summary>
	public float StaticMeshHighFreqTransmission;
	///<summary>Specifies how &quot;rough&quot; the surface is. Surfaces with a high scattering value randomly reflect sound in all directions;</summary>
	public float StaticMeshScattering;
	///<summary>Preset material settings for BSP geometry.</summary>
	public EPhononMaterial BSPMaterialPreset;
	///<summary>How much this material absorbs low frequency sound.</summary>
	public float BSPLowFreqAbsorption;
	///<summary>How much this material absorbs mid frequency sound.</summary>
	public float BSPMidFreqAbsorption;
	///<summary>How much this material absorbs high frequency sound.</summary>
	public float BSPHighFreqAbsorption;
	///<summary>How much this material transmits low frequency sound.</summary>
	public float BSPLowFreqTransmission;
	///<summary>How much this material transmits mid frequency sound.</summary>
	public float BSPMidFreqTransmission;
	///<summary>How much this material transmits high frequency sound.</summary>
	public float BSPHighFreqTransmission;
	///<summary>Specifies how &quot;rough&quot; the surface is. Surfaces with a high scattering value randomly reflect sound in all directions;</summary>
	public float BSPScattering;
	///<summary>Preset material settings for landscape actors.</summary>
	public EPhononMaterial LandscapeMaterialPreset;
	///<summary>How much this material absorbs low frequency sound.</summary>
	public float LandscapeLowFreqAbsorption;
	///<summary>How much this material absorbs mid frequency sound.</summary>
	public float LandscapeMidFreqAbsorption;
	///<summary>How much this material absorbs high frequency sound.</summary>
	public float LandscapeHighFreqAbsorption;
	///<summary>How much this material transmits low frequency sound.</summary>
	public float LandscapeLowFreqTransmission;
	///<summary>How much this material transmits mid frequency sound.</summary>
	public float LandscapeMidFreqTransmission;
	///<summary>How much this material transmits high frequency sound.</summary>
	public float LandscapeHighFreqTransmission;
	///<summary>Specifies how &quot;rough&quot; the surface is. Surfaces with a high scattering value randomly reflect sound in all directions;</summary>
	public float LandscapeScattering;
	///<summary>The number of rays to trace from the listener to a source when simulating volumetric occlusion. Increasing this number increases the smoothness of occlusion transitions, but also increases CPU usage and memory consumption.</summary>
	public int OcclusionSampleCount;
	///<summary>How to simulate listener-centric reverb.</summary>
	public EIplSimulationType ListenerReverbSimulationType;
	///<summary>How much listener-centric reverb should contribute.</summary>
	public float ListenerReverbContribution;
	///<summary>Output of indirect propagation is stored in ambisonics of this order.</summary>
	public int IndirectImpulseResponseOrder;
	///<summary>Length of impulse response to compute for each sound source.</summary>
	public float IndirectImpulseResponseDuration;
	///<summary>How to spatialize indirect sound.</summary>
	public EIplSpatializationMethod IndirectSpatializationMethod;
	///<summary>The minimum distance between a source and a scene surface, used when calculating the energy received at the surface from the source during indirect sound simulation.</summary>
	public float IrradianceMinDistance;
	///<summary>Maximum number of supported sources.</summary>
	public uint MaxSources;
	///<summary>Preset quality settings for realtime simulation.</summary>
	public EQualitySettings RealtimeQualityPreset;
	///<summary>Percentage of CPU cores to use on an end user’s machine for performing real-time computation of environmental effects.</summary>
	public int RealTimeCPUCoresPercentage;
	///<summary>Number of bounces for realtime simulation.</summary>
	public int RealtimeBounces;
	///<summary>Number of rays to trace for realtime simulation.</summary>
	public int RealtimeRays;
	///<summary>Number of secondary rays to trace for realtime simulation.</summary>
	public int RealtimeSecondaryRays;
	///<summary>Preset quality settings for baked simulation.</summary>
	public EQualitySettings BakedQualityPreset;
	///<summary>Percentage of CPU cores to use on a developer’s machine for baking environmental effects during the design phase.</summary>
	public int BakingCPUCoresPercentage;
	///<summary>Number of bounces for baked simulation.</summary>
	public int BakedBounces;
	///<summary>Number of rays to shoot for baked simulation.</summary>
	public int BakedRays;
	///<summary>Number of secondary rays to shoot for baked simulation.</summary>
	public int BakedSecondaryRays;
	///<summary>Maximum number of compute units to reserve on the GPU.</summary>
	public int MaxComputeUnits;
	///<summary>Fraction of maximum reserved CUs that should be used for impulse response (IR) update.</summary>
	public float FractionComputeUnitsForIRUpdate;
	///<summary>TAN override output of indirect propagation is stored in ambisonics of this order.</summary>
	public int TANIndirectImpulseResponseOrder;
	///<summary>TAN override length of impulse response to compute for each sound source.</summary>
	public float TANIndirectImpulseResponseDuration;
	///<summary>TAN override maximum number of supported sources.</summary>
	public uint TANMaxSources;
	///<summary>This is the number of probes that are simultaneously baked on the GPU. Increasing this number results in better utilization of available GPU compute resources,</summary>
	public int RadeonRaysBakingBatchSize;
}
