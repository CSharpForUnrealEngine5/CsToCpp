#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SceneCaptureComponent.h")]
///<summary>-> will be exported to EngineDecalClasses.h</summary>
public partial class USceneCaptureComponent : USceneComponent {
// SceneCaptureComponent
	public ESceneCapturePrimitiveRenderMode PrimitiveRenderMode;
	public byte CaptureSource;
	public bool bCaptureEveryFrame;
	public bool bCaptureOnMovement;
	public bool bAlwaysPersistRenderingState;
	public TArray<TWeakObjectPtr<UPrimitiveComponent>> HiddenComponents;
	public TArray<AActor> HiddenActors;
	public TArray<TWeakObjectPtr<UPrimitiveComponent>> ShowOnlyComponents;
	public TArray<AActor> ShowOnlyActors;
	public float LODDistanceFactor;
	public float MaxViewDistanceOverride;
	public int CaptureSortPriority;
	public bool bUseRayTracingIfEnabled;
	public TArray<FEngineShowFlagsSetting> ShowFlagSettings;
	public string ProfilingEventName;
	public void HideComponent(UObject InComponent) {}
	public void HideActorComponents(UObject InActor,bool bIncludeFromChildActors/*=false*/) {}
	public void ShowOnlyComponent(UObject InComponent) {}
	public void ShowOnlyActorComponents(UObject InActor,bool bIncludeFromChildActors/*=false*/) {}
	public void RemoveShowOnlyComponent(UObject InComponent) {}
	public void RemoveShowOnlyActorComponents(UObject InActor,bool bIncludeFromChildActors/*=false*/) {}
	public void ClearShowOnlyComponents() {}
	public void ClearHiddenComponents() {}
	public void SetCaptureSortPriority(int NewCaptureSortPriority) {}
	public UStaticMesh CaptureMesh;
}
