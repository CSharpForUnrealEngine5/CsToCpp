#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGSelfPruning.h")]
public partial class UPCGSelfPruningSettings : UPCGSettings {
// PCGSelfPruningSettings
	public EPCGSelfPruningType PruningType;
	public float RadiusSimilarityFactor;
	public bool bRandomizedPruning;
}
