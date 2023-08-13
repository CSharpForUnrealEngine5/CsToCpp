namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeRenderCaptureTool.h")]
public partial class UBakeRenderCaptureInputToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Target mesh to sample to</summary>
	public UStaticMesh TargetStaticMesh;
	///<summary>UV channel to use for the target mesh</summary>
	public string TargetUVLayer;
	///<summary>GetTargetUVLayerIndex</summary>
	public int GetTargetUVLayerIndex() { return default; }
	///<summary>GetTargetUVLayerNamesFunc</summary>
	public TArray<string> GetTargetUVLayerNamesFunc() { return default; }
	///<summary>TargetUVLayerNamesList</summary>
	public TArray<string> TargetUVLayerNamesList;
}
