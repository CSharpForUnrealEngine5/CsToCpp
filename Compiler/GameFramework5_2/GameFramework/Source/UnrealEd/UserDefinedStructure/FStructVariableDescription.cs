#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UserDefinedStructure/UserDefinedStructEditorData.h")]
public partial struct FStructVariableDescription {
// StructVariableDescription
	public string VarName;
	public FGuid VarGuid;
	public string FriendlyName;
	public string DefaultValue;
	public string Category;
	public string SubCategory;
	public TSoftObjectPtr<UObject> SubCategoryObject;
	public FEdGraphTerminalType PinValueType;
	public EPinContainerType ContainerType;
	public bool bIsArray_DEPRECATED;
	public bool bIsSet_DEPRECATED;
	public bool bIsMap_DEPRECATED;
	public bool bInvalidMember;
	public bool bDontEditOnInstance;
	public bool bEnableSaveGame;
	public bool bEnableMultiLineText;
	public bool bEnable3dWidget;
	public string CurrentDefaultValue;
	public string ToolTip;
}
