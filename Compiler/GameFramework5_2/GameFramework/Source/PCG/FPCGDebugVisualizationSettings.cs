#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGDebug.h")]
public partial struct FPCGDebugVisualizationSettings {
	public float PointScale;
	public EPCGDebugVisScaleMethod ScaleMethod;
	public TSoftObjectPtr<UStaticMesh> PointMesh;
	public TSoftObjectPtr<UMaterialInterface> MaterialOverride;
	public bool bCheckForDuplicates;
}
