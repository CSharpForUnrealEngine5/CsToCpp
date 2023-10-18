namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a property in the property bag.</summary>
[CppInclude("PropertyBag.h")]
public partial struct FPropertyBagPropertyDesc {
	public UObject ValueTypeObject;
	public FGuid ID;
	public FName Name;
	public EPropertyBagPropertyType ValueType;
	public FPropertyBagContainerTypes ContainerTypes;
	public TArray<FPropertyBagPropertyDescMetaData> MetaData;
}
