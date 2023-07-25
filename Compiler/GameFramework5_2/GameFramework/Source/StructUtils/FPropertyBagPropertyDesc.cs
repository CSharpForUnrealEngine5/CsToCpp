#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyBag.h")]
///<summary>Describes a property in the property bag.</summary>
public partial struct FPropertyBagPropertyDesc {
// PropertyBagPropertyDesc
	public UObject ValueTypeObject;
	public FGuid ID;
	public string Name;
	public EPropertyBagPropertyType ValueType;
	public EPropertyBagContainerType ContainerType;
	public TArray<FPropertyBagPropertyDescMetaData> MetaData;
}
