namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class that stores per-world instance parameter data for a given UMaterialParameterCollection resource.</summary>
[CppInclude("Materials/MaterialParameterCollectionInstance.h")]
public partial class UMaterialParameterCollectionInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Collection resource this instance is based off of.</summary>
	public TWeakObjectPtr<UMaterialParameterCollection> Collection;
}
