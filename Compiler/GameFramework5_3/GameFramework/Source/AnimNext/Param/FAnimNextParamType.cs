namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Representation of a parameter&#39;s type. Serializable, but fairly heavyweight to pass around and compare.</summary>
[CppInclude("Param/ParamType.h")]
public partial struct FAnimNextParamType {
	public UObject ValueTypeObject;
	public EPropertyBagPropertyType ValueType;
	public EPropertyBagContainerType ContainerType;
}
