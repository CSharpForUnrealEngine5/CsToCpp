#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a property in the property bag.</summary>
[CppInclude("PropertyBag.h")]
public partial struct FPropertyBagPropertyDesc {
	public UObject ValueTypeObject;
	public FGuid ID;
	public string Name;
	public EPropertyBagPropertyType ValueType;
	public EPropertyBagContainerType ContainerType;
	public TArray<FPropertyBagPropertyDescMetaData> MetaData;
}
