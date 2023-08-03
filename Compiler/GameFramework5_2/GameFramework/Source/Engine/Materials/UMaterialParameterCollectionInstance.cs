#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class that stores per-world instance parameter data for a given UMaterialParameterCollection resource.</summary>
[CppInclude("Materials/MaterialParameterCollectionInstance.h")]
public partial class UMaterialParameterCollectionInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Collection resource this instance is based off of.</summary>
	public UMaterialParameterCollection Collection;
}
