#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UObject for tracking our list of in-level composure actors - wrapped by a</summary>
[CppInclude("EditorCompElementContainer.h")]
public partial class UEditorCompElementContainer : UObject {
	///<summary>CompElements</summary>
	public TArray<TWeakObjectPtr<ACompositingElement>> CompElements;
}
