#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A script struct that is used to store the value of the property bag instance.</summary>
[CppInclude("PropertyBag.h")]
public partial class UPropertyBag : UScriptStruct {
	///<summary>PropertyDescs</summary>
	public TArray<FPropertyBagPropertyDesc> PropertyDescs;
}
