namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a map of extension collections paired with worlds</summary>
[CppInclude("EditorWorldExtension.h")]
public partial class UEditorWorldExtensionManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Map of all the editor world maps</summary>
	public TArray<UEditorWorldExtensionCollection> EditorWorldExtensionCollection;
}
