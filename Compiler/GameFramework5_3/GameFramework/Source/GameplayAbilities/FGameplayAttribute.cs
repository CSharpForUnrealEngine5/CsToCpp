namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a FGameplayAttributeData or float property inside an attribute set. Using this provides editor UI and helper functions</summary>
[CppInclude("AttributeSet.h")]
public partial struct FGameplayAttribute {
	public string AttributeName;
	public object Attribute;
	public UStruct AttributeOwner;
}
