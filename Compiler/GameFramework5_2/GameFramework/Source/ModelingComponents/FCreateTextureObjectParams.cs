namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FCreateTextureObjectParams is a collection of input data intended to be passed to</summary>
[CppInclude("ModelingObjectsCreationAPI.h")]
public partial struct FCreateTextureObjectParams {
	public int TypeHintExtended;
	public UWorld TargetWorld;
	public UObject StoreRelativeToObject;
	public string BaseName;
	public UTexture2D GeneratedTransientTexture;
}
