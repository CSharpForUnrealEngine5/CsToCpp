namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UObject for tracking our list of in-level composure actors - wrapped by a</summary>
[CppInclude("EditorCompElementContainer.h")]
public partial class UEditorCompElementContainer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CompElements</summary>
	public TArray<TWeakObjectPtr<ACompositingElement>> CompElements;
}
