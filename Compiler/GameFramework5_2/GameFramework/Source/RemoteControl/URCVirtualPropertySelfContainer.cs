#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remote Control Virtual Property which is stores in self defined Property Bag</summary>
[CppInclude("RCVirtualProperty.h")]
public partial class URCVirtualPropertySelfContainer : URCVirtualPropertyBase {
	///<summary>Instanced property bag for store a bag of properties.</summary>
	public FInstancedPropertyBag Bag;
}
