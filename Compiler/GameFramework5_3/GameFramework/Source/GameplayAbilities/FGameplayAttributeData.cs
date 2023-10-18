namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Place in an AttributeSet to create an attribute that can be accesed using FGameplayAttribute. It is strongly encouraged to use this instead of raw float attributes</summary>
[CppInclude("AttributeSet.h")]
public partial struct FGameplayAttributeData {
	public float BaseValue;
	public float CurrentValue;
}
