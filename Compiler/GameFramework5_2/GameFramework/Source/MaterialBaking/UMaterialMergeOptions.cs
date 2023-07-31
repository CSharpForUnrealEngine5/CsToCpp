#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material merge options object</summary>
[CppInclude("MaterialOptions.h")]
public partial class UMaterialMergeOptions : UObject {
	///<summary>EditAnywhere, BlueprintReadWrite, config, Category = MeshSettings, meta = (ExposeOnSpawn)</summary>
	public EMaterialBakeMethod Method;
	///<summary>Blend mode for the final proxy material(s)</summary>
	public EBlendMode BlendMode;
}
