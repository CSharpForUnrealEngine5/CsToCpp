#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposurePipelineBaseActor.h")]
///<summary>Actor designed to implement compositing pipeline in a blueprint.</summary>
public partial class AComposurePipelineBaseActor : AActor {
// ComposurePipelineBaseActor
	public bool bAutoRun;
	public bool bRunInEditor;
	public void SetAutoRun(bool bNewAutoRunVal) {}
	public bool AreChildrenAndSelfAutoRun() { return default; }
	public bool IsActivelyRunning() { return default; }
	public void EnqueueRendering(bool bCameraCutThisFrame) {}
	public void SetAutoRunChildrenAndSelf(bool bAutoRunChildAndSelf) {}
	public bool bAutoRunChildElementsAndSelf;
}
