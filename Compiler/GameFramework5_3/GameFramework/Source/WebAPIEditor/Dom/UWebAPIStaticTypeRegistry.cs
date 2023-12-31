namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds Type information for built-in types.</summary>
[CppInclude("Dom/WebAPITypeRegistry.h")]
public partial class UWebAPIStaticTypeRegistry : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Array of common built-in types.</summary>
	public TArray<UWebAPITypeInfo> BuiltinTypes;
}
