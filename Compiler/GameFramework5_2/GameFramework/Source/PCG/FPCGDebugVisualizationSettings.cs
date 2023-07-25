#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGDebug.h")]
public partial struct FPCGDebugVisualizationSettings {
// PCGDebugVisualizationSettings
	public float PointScale;
	public EPCGDebugVisScaleMethod ScaleMethod;
	public TSoftObjectPtr<UStaticMesh> PointMesh;
	public TSoftObjectPtr<UMaterialInterface> MaterialOverride;
	public bool bCheckForDuplicates;
}
