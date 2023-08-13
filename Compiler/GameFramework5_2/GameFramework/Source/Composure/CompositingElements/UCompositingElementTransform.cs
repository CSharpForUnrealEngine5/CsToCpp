namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementPasses.h")]
public partial class UCompositingElementTransform : UCompositingElementPass {
	public static UClass StaticClass() {return default;}
	///<summary>Marks this pass for &#39;internal use only&#39; - prevents it from being exposed to parent elements.</summary>
	public bool bIntermediate;
	///<summary>ApplyTransform</summary>
	public UTexture ApplyTransform(UTexture Input,UComposurePostProcessingPassProxy PostProcessProxy,ACameraActor TargetCamera) { return default; }
	///<summary>FindNamedPrePassResult</summary>
	public UTexture FindNamedPrePassResult(string PassLookupName) { return default; }
}
