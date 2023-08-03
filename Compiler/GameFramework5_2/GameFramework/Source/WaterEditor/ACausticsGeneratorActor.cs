#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CausticsGeneratorActor.h")]
public partial class ACausticsGeneratorActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>UPROPERTY(BlueprintReadWrite, NonTransactional, meta = (Category = &quot;Default&quot;))</summary>
	public USceneComponent DefaultSceneRoot;
	///<summary>EditorTick</summary>
	public  void EditorTick(float DeltaSeconds) {}
	///<summary>SetEditorTickEnabled</summary>
	public  void SetEditorTickEnabled(bool bEnabled) {}
	///<summary>EditorTickIsEnabled</summary>
	public bool EditorTickIsEnabled;
	///<summary>SpawnWaterPreviewGrid</summary>
	public  void SpawnWaterPreviewGrid(UHierarchicalInstancedStaticMeshComponent HISMC,float GridSize,int GridTiles) {}
	///<summary>SpawnCausticParticleGrid</summary>
	public  void SpawnCausticParticleGrid(UHierarchicalInstancedStaticMeshComponent HISMC,float GridSize,int GridTiles) {}
}
