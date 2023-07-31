#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelEditorMenuContext.h")]
public partial class ULevelEditorContextMenuContext : UObject {
	///<summary>ContextType</summary>
	public ELevelEditorMenuContext ContextType;
	///<summary>CurrentSelection</summary>
	public UTypedElementSelectionSet CurrentSelection;
	///<summary>CursorWorldLocation</summary>
	public FVector CursorWorldLocation;
	///<summary>SelectedComponents</summary>
	public TArray<UActorComponent> SelectedComponents;
	///<summary>If the ContextType is Viewport this property can be set to the HitProxy actor that triggered the ContextMenu.</summary>
	public TWeakObjectPtr<AActor> HitProxyActor;
	///<summary>GetScriptHitProxyElement</summary>
	public  FScriptTypedElementHandle GetScriptHitProxyElement() { return default; }
}
