#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AttributeSet.h")]
///<summary>Describes a FGameplayAttributeData or float property inside an attribute set. Using this provides editor UI and helper functions</summary>
public partial struct FGameplayAttribute {
// GameplayAttribute
	public string AttributeName;
	public object Attribute;
	public UStruct AttributeOwner;
}
