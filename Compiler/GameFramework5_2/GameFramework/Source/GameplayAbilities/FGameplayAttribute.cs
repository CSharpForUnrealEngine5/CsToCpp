#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a FGameplayAttributeData or float property inside an attribute set. Using this provides editor UI and helper functions</summary>
[CppInclude("AttributeSet.h")]
public partial struct FGameplayAttribute {
	public string AttributeName;
	public object Attribute;
	public UStruct AttributeOwner;
}
