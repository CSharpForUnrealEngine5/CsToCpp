namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to define the type of information carried on this pin</summary>
[CppInclude("EdGraph/EdGraphPin.h")]
public partial struct FEdGraphPinType {
	public FName PinCategory;
	public FName PinSubCategory;
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
