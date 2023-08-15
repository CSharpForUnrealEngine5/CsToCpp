namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the runtime settings for the Water plugin.</summary>
[CppInclude("WaterRuntimeSettings.h")]
public partial class UWaterRuntimeSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Collision channel to use for tracing and blocking water bodies</summary>
	public ECollisionChannel CollisionChannelForWaterTraces;
	///<summary>Material Parameter Collection for everything water-related</summary>
	public TSoftObjectPtr<UMaterialParameterCollection> MaterialParameterCollection;
	///<summary>Offset in Z for the water body icon in world-space.</summary>
	public float WaterBodyIconWorldZOffset;
	///<summary>Default collision profile name of water bodies</summary>
	public FName DefaultWaterCollisionProfileName;
	///<summary>DefaultWaterInfoMaterial</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultWaterInfoMaterial;
	///<summary>WaterBodyRiverComponentClass</summary>
	public UClass WaterBodyRiverComponentClass;
	///<summary>WaterBodyLakeComponentClass</summary>
	public UClass WaterBodyLakeComponentClass;
	///<summary>WaterBodyOceanComponentClass</summary>
	public UClass WaterBodyOceanComponentClass;
	///<summary>WaterBodyCustomComponentClass</summary>
	public UClass WaterBodyCustomComponentClass;
	///<summary>WaterBodyIconWorldSize_DEPRECATED</summary>
	public float WaterBodyIconWorldSize_DEPRECATED;
}
