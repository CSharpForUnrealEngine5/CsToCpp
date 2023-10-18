namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StructUtilsTestTypes.h")]
public partial class UTestObjectWithPropertyBag : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Bag</summary>
	public FInstancedPropertyBag Bag;
}
