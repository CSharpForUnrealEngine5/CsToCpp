#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Debug options for Lightmass</summary>
public partial struct FLightmassDebugOptions {
// LightmassDebugOptions
	public bool bDebugMode;
	public bool bStatsEnabled;
	public bool bGatherBSPSurfacesAcrossComponents;
	public float CoplanarTolerance;
	public bool bUseImmediateImport;
	public bool bImmediateProcessMappings;
	public bool bSortMappings;
	public bool bDumpBinaryFiles;
	public bool bDebugMaterials;
	public bool bPadMappings;
	public bool bDebugPaddings;
	public bool bOnlyCalcDebugTexelMappings;
	public bool bUseRandomColors;
	public bool bColorBordersGreen;
	public bool bColorByExecutionTime;
	public float ExecutionTimeDivisor;
}
