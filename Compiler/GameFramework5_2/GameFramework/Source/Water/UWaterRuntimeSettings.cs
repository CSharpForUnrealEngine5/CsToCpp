#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterRuntimeSettings.h")]
///<summary>Implements the runtime settings for the Water plugin.</summary>
public partial class UWaterRuntimeSettings : UDeveloperSettings {
// WaterRuntimeSettings
	public byte CollisionChannelForWaterTraces;
	public TSoftObjectPtr<UMaterialParameterCollection> MaterialParameterCollection;
	public float WaterBodyIconWorldZOffset;
	public string DefaultWaterCollisionProfileName;
	public TSoftObjectPtr<UMaterialInterface> DefaultWaterInfoMaterial;
	public UClass WaterBodyRiverComponentClass;
	public UClass WaterBodyLakeComponentClass;
	public UClass WaterBodyOceanComponentClass;
	public UClass WaterBodyCustomComponentClass;
	public float WaterBodyIconWorldSize_DEPRECATED;
}
