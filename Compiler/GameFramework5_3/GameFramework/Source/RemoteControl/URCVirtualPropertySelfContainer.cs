namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remote Control Virtual Property which is stores in self defined Property Bag</summary>
[CppInclude("RCVirtualProperty.h")]
public partial class URCVirtualPropertySelfContainer : URCVirtualPropertyBase {
	public static UClass StaticClass() {return default;}
	///<summary>Instanced property bag for store a bag of properties.</summary>
	public FInstancedPropertyBag Bag;
}
