#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug options for Lightmass</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FLightmassDebugOptions {
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
