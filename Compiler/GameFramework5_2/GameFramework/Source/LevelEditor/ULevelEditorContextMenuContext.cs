#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelEditorMenuContext.h")]
public partial class ULevelEditorContextMenuContext : UObject {
// LevelEditorContextMenuContext
	public ELevelEditorMenuContext ContextType;
	public UTypedElementSelectionSet CurrentSelection;
	public FVector CursorWorldLocation;
	public TArray<UActorComponent> SelectedComponents;
	public TWeakObjectPtr<AActor> HitProxyActor;
	public  FScriptTypedElementHandle GetScriptHitProxyElement() { return default; }
}
