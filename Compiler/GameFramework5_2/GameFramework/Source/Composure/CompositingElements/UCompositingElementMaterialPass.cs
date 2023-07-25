#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementTransforms.h")]
///<summary>UCompositingElementMaterialPass</summary>
public partial class UCompositingElementMaterialPass : UCompositingPostProcessPass {
// CompositingElementMaterialPass
	public FCompositingMaterial Material;
	public void SetMaterialInterface(UObject NewMaterial) {}
	public bool SetParameterMapping(string TextureParamName,string ComposureLayerName) { return default; }
	public void ApplyMaterialParams(UObject MID) {}
}
