#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to define the type of information carried on this pin</summary>
[CppInclude("EdGraph/EdGraphPin.h")]
public partial struct FEdGraphPinType {
	public string PinCategory;
	public string PinSubCategory;
	public TWeakObjectPtr<UObject> PinSubCategoryObject;
	public FSimpleMemberReference PinSubCategoryMemberReference;
	public FEdGraphTerminalType PinValueType;
	public EPinContainerType ContainerType;
	public bool bIsArray_DEPRECATED;
	public bool bIsReference;
	public bool bIsConst;
	public bool bIsWeakPointer;
	public bool bIsUObjectWrapper;
	public bool bSerializeAsSinglePrecisionFloat;
}
