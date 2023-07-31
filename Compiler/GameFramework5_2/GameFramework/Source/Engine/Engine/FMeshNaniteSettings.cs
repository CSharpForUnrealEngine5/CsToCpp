#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings applied when building Nanite data.</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FMeshNaniteSettings {
	public bool bEnabled;
	public bool bPreserveArea;
	public int PositionPrecision;
	public int NormalPrecision;
	public uint TargetMinimumResidencyInKB;
	public float KeepPercentTriangles;
	public float TrimRelativeError;
	public float FallbackPercentTriangles;
	public float FallbackRelativeError;
	public int DisplacementUVChannel;
	public TArray<FMeshDisplacementMap> DisplacementMaps;
}
