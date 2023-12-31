namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds Type information for a given Schema.</summary>
[CppInclude("Dom/WebAPITypeRegistry.h")]
public partial class UWebAPITypeRegistry : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Array of TypeInfo objects to generate (no built-in types).</summary>
	public TArray<UWebAPITypeInfo> GeneratedTypes;
}
