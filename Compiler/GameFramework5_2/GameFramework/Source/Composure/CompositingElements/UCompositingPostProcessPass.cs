namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementTransforms.h")]
public partial class UCompositingPostProcessPass : UCompositingElementTransform {
	public static UClass StaticClass() {return default;}
	///<summary>RenderScale</summary>
	public float RenderScale;
	///<summary>PostProcessPasses</summary>
	public TArray<UComposurePostProcessPassPolicy> PostProcessPasses;
}
