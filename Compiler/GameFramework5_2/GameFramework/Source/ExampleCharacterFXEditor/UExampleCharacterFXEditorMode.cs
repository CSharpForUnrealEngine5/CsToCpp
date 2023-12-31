namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExampleCharacterFXEditorMode.h")]
public partial class UExampleCharacterFXEditorMode : UBaseCharacterFXEditorMode {
	public static UClass StaticClass() {return default;}
	///<summary>NOTE: Since the Example CharacterFX Editor is not the &quot;default&quot; editor for a particular asset type and we still want to have something to render,</summary>
	public TArray<UDynamicMeshComponent> DynamicMeshComponents;
}
