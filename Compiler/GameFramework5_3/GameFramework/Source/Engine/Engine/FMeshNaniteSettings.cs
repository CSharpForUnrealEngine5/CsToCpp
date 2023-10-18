namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings applied when building Nanite data.</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FMeshNaniteSettings {
	public bool bEnabled;
	public bool bPreserveArea;
	public bool bExplicitTangents;
	public int PositionPrecision;
	public int NormalPrecision;
	public int TangentPrecision;
	public uint TargetMinimumResidencyInKB;
	public float KeepPercentTriangles;
	public float TrimRelativeError;
	public ENaniteFallbackTarget FallbackTarget;
	public float FallbackPercentTriangles;
	public float FallbackRelativeError;
	public int DisplacementUVChannel;
	public TArray<FMeshDisplacementMap> DisplacementMaps;
}
