namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FCreateMaterialObjectParams is a collection of input data intended to be passed to</summary>
[CppInclude("ModelingObjectsCreationAPI.h")]
public partial struct FCreateMaterialObjectParams {
	public UWorld TargetWorld;
	public UObject StoreRelativeToObject;
	public string BaseName;
	public UMaterialInterface MaterialToDuplicate;
}
