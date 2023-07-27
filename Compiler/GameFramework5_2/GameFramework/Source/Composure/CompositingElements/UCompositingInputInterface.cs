#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementInputs.h")]
public partial class UCompositingInputInterface : UInterface {
// CompositingInputInterface
	public  void OnFrameBegin(UCompositingInputInterfaceProxy Proxy,bool bCameraCutThisFrame) {}
	public  UTexture GenerateInput(UCompositingInputInterfaceProxy Proxy) { return default; }
	public  void OnFrameEnd(UCompositingInputInterfaceProxy Proxy) {}
}
