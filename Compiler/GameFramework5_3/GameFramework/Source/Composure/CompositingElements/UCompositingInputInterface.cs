namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementInputs.h")]
public partial class UCompositingInputInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>OnFrameBegin</summary>
	public void OnFrameBegin(UCompositingInputInterfaceProxy Proxy,bool bCameraCutThisFrame) {}
	///<summary>GenerateInput</summary>
	public UTexture GenerateInput(UCompositingInputInterfaceProxy Proxy) { return default; }
	///<summary>OnFrameEnd</summary>
	public void OnFrameEnd(UCompositingInputInterfaceProxy Proxy) {}
}
