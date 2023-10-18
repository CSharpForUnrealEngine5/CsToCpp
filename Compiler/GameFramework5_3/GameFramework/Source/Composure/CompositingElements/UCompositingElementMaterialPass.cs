namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UCompositingElementMaterialPass</summary>
[CppInclude("CompositingElements/CompositingElementTransforms.h")]
public partial class UCompositingElementMaterialPass : UCompositingPostProcessPass {
	public static UClass StaticClass() {return default;}
	///<summary>Material</summary>
	public FCompositingMaterial Material;
	///<summary>Set the material interface used by current material pass.</summary>
	public void SetMaterialInterface(UMaterialInterface NewMaterial) {}
	///<summary>Set the parameter mappings between texture parameters and composure layers. Users can not create new entries into the map as the keys are read only.</summary>
	public bool SetParameterMapping(FName TextureParamName,FName ComposureLayerName) { return default; }
	///<summary>ApplyMaterialParams</summary>
	public void ApplyMaterialParams(UMaterialInstanceDynamic MID) {}
}
