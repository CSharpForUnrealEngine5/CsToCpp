#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>-&gt; will be exported to EngineDecalClasses.h</summary>
[CppInclude("Components/SceneCaptureComponent.h")]
public partial class USceneCaptureComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Controls what primitives get rendered into the scene capture.</summary>
	public ESceneCapturePrimitiveRenderMode PrimitiveRenderMode;
	///<summary>CaptureSource</summary>
	public ESceneCaptureSource CaptureSource;
	///<summary>Whether to update the capture&#39;s contents every frame.  If disabled, the component will render once on load and then only when moved.</summary>
	public bool bCaptureEveryFrame;
	///<summary>Whether to update the capture&#39;s contents on movement.  Disable if you are going to capture manually from blueprint.</summary>
	public bool bCaptureOnMovement;
	///<summary>Whether to persist the rendering state even if bCaptureEveryFrame==false.  This allows velocities for Motion Blur and Temporal AA to be computed.</summary>
	public bool bAlwaysPersistRenderingState;
	///<summary>The components won&#39;t rendered by current component.</summary>
	public TArray<TWeakObjectPtr<UPrimitiveComponent>> HiddenComponents;
	///<summary>The actors to hide in the scene capture.</summary>
	public TArray<AActor> HiddenActors;
	///<summary>The only components to be rendered by this scene capture, if PrimitiveRenderMode is set to UseShowOnlyList.</summary>
	public TArray<TWeakObjectPtr<UPrimitiveComponent>> ShowOnlyComponents;
	///<summary>The only actors to be rendered by this scene capture, if PrimitiveRenderMode is set to UseShowOnlyList.</summary>
	public TArray<AActor> ShowOnlyActors;
	///<summary>Scales the distance used by LOD. Set to values greater than 1 to cause the scene capture to use lower LODs than the main view to speed up the scene capture pass.</summary>
	public float LODDistanceFactor;
	///<summary>if &gt; 0, sets a maximum render distance override.  Can be used to cull distant objects from a reflection if the reflecting plane is in an enclosed area like a hallway or room</summary>
	public float MaxViewDistanceOverride;
	///<summary>Capture priority within the frame to sort scene capture on GPU to resolve interdependencies between multiple capture components. Highest come first.</summary>
	public int CaptureSortPriority;
	///<summary>Whether to use ray tracing for this capture. Ray Tracing must be enabled in the project.</summary>
	public bool bUseRayTracingIfEnabled;
	///<summary>ShowFlags for the SceneCapture&#39;s ViewFamily, to control rendering settings for this view. Hidden but accessible through details customization</summary>
	public TArray<FEngineShowFlagsSetting> ShowFlagSettings;
	///<summary>Name of the profiling event.</summary>
	public string ProfilingEventName;
	///<summary>Adds the component to our list of hidden components.</summary>
	public  void HideComponent(UPrimitiveComponent InComponent) {}
	///<summary>Adds all primitive components in the actor to our list of hidden components.</summary>
	public  void HideActorComponents(AActor InActor,bool bIncludeFromChildActors/*=false*/) {}
	///<summary>Adds the component to our list of show-only components.</summary>
	public  void ShowOnlyComponent(UPrimitiveComponent InComponent) {}
	///<summary>Adds all primitive components in the actor to our list of show-only components.</summary>
	public  void ShowOnlyActorComponents(AActor InActor,bool bIncludeFromChildActors/*=false*/) {}
	///<summary>Removes a component from the Show Only list.</summary>
	public  void RemoveShowOnlyComponent(UPrimitiveComponent InComponent) {}
	///<summary>Removes an actor&#39;s components from the Show Only list.</summary>
	public  void RemoveShowOnlyActorComponents(AActor InActor,bool bIncludeFromChildActors/*=false*/) {}
	///<summary>Clears the Show Only list.</summary>
	public  void ClearShowOnlyComponents() {}
	///<summary>Clears the hidden list.</summary>
	public  void ClearHiddenComponents() {}
	///<summary>Changes the value of TranslucentSortPriority.</summary>
	public  void SetCaptureSortPriority(int NewCaptureSortPriority) {}
	///<summary>The mesh used by ProxyMeshComponent</summary>
	public UStaticMesh CaptureMesh;
}
