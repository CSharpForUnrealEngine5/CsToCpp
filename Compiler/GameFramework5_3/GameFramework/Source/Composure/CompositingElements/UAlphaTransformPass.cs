namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementTransforms.h")]
public partial class UAlphaTransformPass : UCompositingElementTransform {
	public static UClass StaticClass() {return default;}
	///<summary>AlphaScale</summary>
	public float AlphaScale;
	///<summary>DefaultMaterial</summary>
	public UMaterialInterface DefaultMaterial;
	///<summary>AlphaTransformMID</summary>
	public UMaterialInstanceDynamic AlphaTransformMID;
}
