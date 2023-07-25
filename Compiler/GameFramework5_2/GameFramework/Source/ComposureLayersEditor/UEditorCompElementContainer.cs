#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorCompElementContainer.h")]
///<summary>UObject for tracking our list of in-level composure actors - wrapped by a</summary>
public partial class UEditorCompElementContainer : UObject {
// EditorCompElementContainer
	public TArray<TWeakObjectPtr<ACompositingElement>> CompElements;
}
