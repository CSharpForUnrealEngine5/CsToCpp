#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the API used to get information about water at runtime</summary>
[CppInclude("WaterSubsystem.h")]
public partial class UWaterSubsystem : UTickableWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>IsShallowWaterSimulationEnabled</summary>
	public  bool IsShallowWaterSimulationEnabled() { return default; }
	///<summary>IsUnderwaterPostProcessEnabled</summary>
	public  bool IsUnderwaterPostProcessEnabled() { return default; }
	///<summary>GetShallowWaterMaxDynamicForces</summary>
	public static int GetShallowWaterMaxDynamicForces() { return default; }
	///<summary>GetShallowWaterMaxImpulseForces</summary>
	public static int GetShallowWaterMaxImpulseForces() { return default; }
	///<summary>GetShallowWaterSimulationRenderTargetSize</summary>
	public static int GetShallowWaterSimulationRenderTargetSize() { return default; }
	///<summary>IsWaterRenderingEnabled</summary>
	public  bool IsWaterRenderingEnabled() { return default; }
	///<summary>GetWaterTimeSeconds</summary>
	public  float GetWaterTimeSeconds() { return default; }
	///<summary>GetSmoothedWorldTimeSeconds</summary>
	public  float GetSmoothedWorldTimeSeconds() { return default; }
	///<summary>GetCameraUnderwaterDepth</summary>
	public  float GetCameraUnderwaterDepth() { return default; }
	///<summary>PrintToWaterLog</summary>
	public  void PrintToWaterLog(string Message,bool bWarning) {}
	///<summary>Returns the base height of the ocean. This should correspond to its world Z position</summary>
	public  float GetOceanBaseHeight() { return default; }
	///<summary>Returns the relative flood height</summary>
	public  float GetOceanFloodHeight() { return default; }
	///<summary>Returns the total height of the ocean. This should correspond to the base height plus any additional height, like flood for example</summary>
	public  float GetOceanTotalHeight() { return default; }
	///<summary>SetOceanFloodHeight</summary>
	public  void SetOceanFloodHeight(float InFloodHeight) {}
	///<summary>BuoyancyManager</summary>
	public ABuoyancyManager BuoyancyManager;
	///<summary>OnCameraUnderwaterStateChanged</summary>
	public FOnCameraUnderwaterStateChanged OnCameraUnderwaterStateChanged;
	///<summary>OnWaterScalabilityChanged</summary>
	public FOnWaterScalabilityChanged OnWaterScalabilityChanged;
	///<summary>DefaultRiverMesh</summary>
	public UStaticMesh DefaultRiverMesh;
	///<summary>DefaultLakeMesh</summary>
	public UStaticMesh DefaultLakeMesh;
	///<summary>The parameter collection asset that holds the global parameters that are updated by this actor</summary>
	public UMaterialParameterCollection MaterialParameterCollection;
}
