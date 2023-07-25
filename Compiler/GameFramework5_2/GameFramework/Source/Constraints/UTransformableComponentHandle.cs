#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TransformableHandle.h")]
///<summary>UTransformableComponentHandle</summary>
public partial class UTransformableComponentHandle : UTransformableHandle {
// TransformableComponentHandle
	public TWeakObjectPtr<USceneComponent> Component;
	public string SocketName;
}
