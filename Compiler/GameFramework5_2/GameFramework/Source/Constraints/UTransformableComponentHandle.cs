#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTransformableComponentHandle</summary>
[CppInclude("TransformableHandle.h")]
public partial class UTransformableComponentHandle : UTransformableHandle {
	///<summary>The Component that this handle is pointing at.</summary>
	public TWeakObjectPtr<USceneComponent> Component;
	///<summary>Optional socket name on Component.</summary>
	public string SocketName;
}
