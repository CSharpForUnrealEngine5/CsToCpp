#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Settings applied when building Nanite data.</summary>
public partial struct FMeshNaniteSettings {
// MeshNaniteSettings
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
