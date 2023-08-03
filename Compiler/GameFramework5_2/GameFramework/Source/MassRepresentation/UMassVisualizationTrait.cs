#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassVisualizationTrait.h")]
public partial class UMassVisualizationTrait : UMassEntityTraitBase {
	public static UClass StaticClass() {return default;}
	///<summary>Instanced static mesh information for this agent</summary>
	public FStaticMeshInstanceVisualizationDesc StaticMeshInstanceDesc;
	///<summary>Actor class of this agent when spawned in high resolution</summary>
	public UClass HighResTemplateActor;
	///<summary>Actor class of this agent when spawned in low resolution</summary>
	public UClass LowResTemplateActor;
	///<summary>Allow subclasses to override the representation subsystem to use</summary>
	public UClass RepresentationSubsystemClass;
	///<summary>Configuration parameters for the representation processor</summary>
	public FMassRepresentationParameters Params;
	///<summary>Configuration parameters for the visualization LOD processor</summary>
	public FMassVisualizationLODParameters LODParams;
}
