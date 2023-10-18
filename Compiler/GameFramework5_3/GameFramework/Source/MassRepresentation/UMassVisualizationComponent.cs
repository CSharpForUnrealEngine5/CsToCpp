namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This component handles all the static mesh instances for a MassRepresentationProcessor and is an actor component off a MassVisualizer actor.</summary>
[CppInclude("MassVisualizationComponent.h")]
public partial class UMassVisualizationComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The information of all the instanced static meshes</summary>
	public TArray<FMassInstancedStaticMeshInfo> InstancedStaticMeshInfos;
}
