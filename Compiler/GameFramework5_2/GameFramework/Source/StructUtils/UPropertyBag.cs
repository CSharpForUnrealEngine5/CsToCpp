namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A script struct that is used to store the value of the property bag instance.</summary>
[CppInclude("PropertyBag.h")]
public partial class UPropertyBag : UScriptStruct {
	public static UClass StaticClass() {return default;}
	///<summary>PropertyDescs</summary>
	public TArray<FPropertyBagPropertyDesc> PropertyDescs;
}
