#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyBag.h")]
///<summary>Property bag property type, loosely based on BluePrint pin types.</summary>
public enum EPropertyBagPropertyType {
	None=0,
	Bool=1,
	Byte=2,
	Int32=3,
	Int64=4,
	Float=5,
	Double=6,
	Name=7,
	String=8,
	Text=9,
	Enum=10,
	Struct=11,
	Object=12,
	SoftObject=13,
	Class=14,
	SoftClass=15,
}
