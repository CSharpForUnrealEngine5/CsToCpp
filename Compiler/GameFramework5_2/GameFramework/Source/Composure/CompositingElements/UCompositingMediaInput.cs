#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingElementInputs.h")]
public partial class UCompositingMediaInput : UCompositingElementInput {
	///<summary>MediaTransformMaterial</summary>
	public FCompositingMaterial MediaTransformMaterial;
	///<summary>DefaultMaterial</summary>
	public UMaterialInterface DefaultMaterial;
	///<summary>DefaultTestPlateMaterial</summary>
	public UMaterialInterface DefaultTestPlateMaterial;
	///<summary>FallbackMID</summary>
	public UMaterialInstanceDynamic FallbackMID;
}
