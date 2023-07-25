#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseCharacterFXEditorMode.h")]
///<summary>The CharacterFX EditorMode stores much of the inter-tool state, including ToolTargets.</summary>
public partial class UBaseCharacterFXEditorMode : UEdMode {
// BaseCharacterFXEditorMode
	public TArray<UObject> OriginalObjectsToEdit;
	public TArray<UToolTarget> ToolTargets;
}
