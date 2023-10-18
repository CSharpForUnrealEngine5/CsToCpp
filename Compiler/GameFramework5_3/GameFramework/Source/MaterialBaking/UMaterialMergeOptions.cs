namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material merge options object</summary>
[CppInclude("MaterialOptions.h")]
public partial class UMaterialMergeOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>EditAnywhere, BlueprintReadWrite, config, Category = MeshSettings, meta = (ExposeOnSpawn)</summary>
	public EMaterialBakeMethod Method;
	///<summary>Blend mode for the final proxy material(s)</summary>
	public EBlendMode BlendMode;
}
