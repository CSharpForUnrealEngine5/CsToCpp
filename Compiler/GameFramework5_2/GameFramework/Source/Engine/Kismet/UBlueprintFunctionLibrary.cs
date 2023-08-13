namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is a base class for any function libraries exposed to blueprints.</summary>
[CppInclude("Kismet/BlueprintFunctionLibrary.h")]
public partial class UBlueprintFunctionLibrary : UObject {
	public static UClass StaticClass() {return default;}
}
