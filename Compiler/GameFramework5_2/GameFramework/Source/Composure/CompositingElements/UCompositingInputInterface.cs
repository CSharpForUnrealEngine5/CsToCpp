#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementInputs.h")]
public partial class UCompositingInputInterface : UInterface {
// CompositingInputInterface
	public void OnFrameBegin(UObject Proxy,bool bCameraCutThisFrame) {}
	public UObject GenerateInput(UObject Proxy) { return default; }
	public void OnFrameEnd(UObject Proxy) {}
}
