namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>HACK: We need a UClass here or UHT will complain.</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial class USlateTypes : UObject {
	public static UClass StaticClass() {return default;}
}
