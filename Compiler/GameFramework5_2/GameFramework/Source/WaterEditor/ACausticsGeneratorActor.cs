#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CausticsGeneratorActor.h")]
public partial class ACausticsGeneratorActor : AActor {
// CausticsGeneratorActor
	public USceneComponent DefaultSceneRoot;
	public  void EditorTick(float DeltaSeconds) {}
	public  void SetEditorTickEnabled(bool bEnabled) {}
	public bool EditorTickIsEnabled;
	public  void SpawnWaterPreviewGrid(UHierarchicalInstancedStaticMeshComponent HISMC,float GridSize,int GridTiles) {}
	public  void SpawnCausticParticleGrid(UHierarchicalInstancedStaticMeshComponent HISMC,float GridSize,int GridTiles) {}
}
