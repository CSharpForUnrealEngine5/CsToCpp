namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTransformableComponentHandle</summary>
[CppInclude("TransformableHandle.h")]
public partial class UTransformableComponentHandle : UTransformableHandle {
	public static UClass StaticClass() {return default;}
	///<summary>The Component that this handle is pointing at.</summary>
	public TWeakObjectPtr<USceneComponent> Component;
	///<summary>Optional socket name on Component.</summary>
	public string SocketName;
}
