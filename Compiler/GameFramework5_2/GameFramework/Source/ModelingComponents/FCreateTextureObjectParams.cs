#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelingObjectsCreationAPI.h")]
///<summary>FCreateTextureObjectParams is a collection of input data intended to be passed to</summary>
public partial struct FCreateTextureObjectParams {
// CreateTextureObjectParams
	public int TypeHintExtended;
	public UWorld TargetWorld;
	public UObject StoreRelativeToObject;
	public string BaseName;
	public UTexture2D GeneratedTransientTexture;
}
