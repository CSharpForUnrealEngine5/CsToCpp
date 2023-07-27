#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeRenderCaptureTool.h")]
public partial class UBakeRenderCaptureInputToolProperties : UInteractiveToolPropertySet {
// BakeRenderCaptureInputToolProperties
	public UStaticMesh TargetStaticMesh;
	public string TargetUVLayer;
	public  int GetTargetUVLayerIndex() { return default; }
	public  TArray<string> GetTargetUVLayerNamesFunc() { return default; }
	public TArray<string> TargetUVLayerNamesList;
}
