#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementTransforms.h")]
public partial class UCompositingPostProcessPass : UCompositingElementTransform {
	///<summary>RenderScale</summary>
	public float RenderScale;
	///<summary>PostProcessPasses</summary>
	public TArray<UComposurePostProcessPassPolicy> PostProcessPasses;
}
