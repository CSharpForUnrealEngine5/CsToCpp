namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class has been soft-deprecated. Use MassStationaryVisualizationTrait or MassMovableVisualizationTrait</summary>
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
	///<summary>If set to true will result in the visualization-related fragments being added to server-size entities as well.</summary>
	public bool bAllowServerSideVisualization;
	///<summary>the property is marked like this to ensure it won&#39;t show up in UI</summary>
	public bool bCanModifyRepresentationSubsystemClass;
}
