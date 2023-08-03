#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor designed to implement compositing pipeline in a blueprint.</summary>
[CppInclude("ComposurePipelineBaseActor.h")]
public partial class AComposurePipelineBaseActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>When set, we&#39;ll call EnqueueRendering() each frame automatically. If left</summary>
	public bool bAutoRun;
	///<summary>With bAutoRun, this will run EnqueueRendering() in editor - enqueuing render calls along with Editor scene rendering.</summary>
	public bool bRunInEditor;
	///<summary>SetAutoRun</summary>
	public  void SetAutoRun(bool bNewAutoRunVal) {}
	///<summary>AreChildrenAndSelfAutoRun</summary>
	public  bool AreChildrenAndSelfAutoRun() { return default; }
	///<summary>IsActivelyRunning</summary>
	public  bool IsActivelyRunning() { return default; }
	///<summary>Entry point for a composure Blueprint to do its render enqueuing from.</summary>
	public  void EnqueueRendering(bool bCameraCutThisFrame) {}
	///<summary>SetAutoRunChildrenAndSelf</summary>
	public  void SetAutoRunChildrenAndSelf(bool bAutoRunChildAndSelf) {}
	///<summary>When set to false, all composure elements including itself&#39;s rendering will not automatically be called in the pipeline.</summary>
	public bool bAutoRunChildElementsAndSelf;
}
