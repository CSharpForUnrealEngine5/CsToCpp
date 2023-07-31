#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The CharacterFX EditorMode stores much of the inter-tool state, including ToolTargets.</summary>
[CppInclude("BaseCharacterFXEditorMode.h")]
public partial class UBaseCharacterFXEditorMode : UEdMode {
	///<summary>Stores original input objects</summary>
	public TArray<UObject> OriginalObjectsToEdit;
	///<summary>Tool targets created from OriginalObjectsToEdit (and 1:1 with that array) that provide us with dynamic meshes</summary>
	public TArray<UToolTarget> ToolTargets;
}
