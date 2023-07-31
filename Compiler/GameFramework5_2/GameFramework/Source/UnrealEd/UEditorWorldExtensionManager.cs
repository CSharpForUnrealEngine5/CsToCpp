#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a map of extension collections paired with worlds</summary>
[CppInclude("EditorWorldExtension.h")]
public partial class UEditorWorldExtensionManager : UObject {
	///<summary>Map of all the editor world maps</summary>
	public TArray<UEditorWorldExtensionCollection> EditorWorldExtensionCollection;
}
