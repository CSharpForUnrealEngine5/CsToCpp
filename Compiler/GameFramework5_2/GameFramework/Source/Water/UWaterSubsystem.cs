#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterSubsystem.h")]
///<summary>This is the API used to get information about water at runtime</summary>
public partial class UWaterSubsystem : UTickableWorldSubsystem {
// WaterSubsystem
	public  bool IsShallowWaterSimulationEnabled() { return default; }
	public  bool IsUnderwaterPostProcessEnabled() { return default; }
	public static int GetShallowWaterMaxDynamicForces() { return default; }
	public static int GetShallowWaterMaxImpulseForces() { return default; }
	public static int GetShallowWaterSimulationRenderTargetSize() { return default; }
	public  bool IsWaterRenderingEnabled() { return default; }
	public  float GetWaterTimeSeconds() { return default; }
	public  float GetSmoothedWorldTimeSeconds() { return default; }
	public  float GetCameraUnderwaterDepth() { return default; }
	public  void PrintToWaterLog(string Message,bool bWarning) {}
	public  float GetOceanBaseHeight() { return default; }
	public  float GetOceanFloodHeight() { return default; }
	public  float GetOceanTotalHeight() { return default; }
	public  void SetOceanFloodHeight(float InFloodHeight) {}
	public ABuoyancyManager BuoyancyManager;
	public FOnCameraUnderwaterStateChanged OnCameraUnderwaterStateChanged;
	public FOnWaterScalabilityChanged OnWaterScalabilityChanged;
	public UStaticMesh DefaultRiverMesh;
	public UStaticMesh DefaultLakeMesh;
	public UMaterialParameterCollection MaterialParameterCollection;
}
