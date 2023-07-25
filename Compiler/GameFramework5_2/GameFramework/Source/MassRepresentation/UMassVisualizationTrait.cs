#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassVisualizationTrait.h")]
public partial class UMassVisualizationTrait : UMassEntityTraitBase {
// MassVisualizationTrait
	public FStaticMeshInstanceVisualizationDesc StaticMeshInstanceDesc;
	public UClass HighResTemplateActor;
	public UClass LowResTemplateActor;
	public UClass RepresentationSubsystemClass;
	public FMassRepresentationParameters Params;
	public FMassVisualizationLODParameters LODParams;
}
