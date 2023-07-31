#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to define information for terminal types, e.g. types that can be contained</summary>
[CppInclude("EdGraph/EdGraphNode.h")]
public partial struct FEdGraphTerminalType {
	public string TerminalCategory;
	public string TerminalSubCategory;
	public TWeakObjectPtr<UObject> TerminalSubCategoryObject;
	public bool bTerminalIsConst;
	public bool bTerminalIsWeakPointer;
	public bool bTerminalIsUObjectWrapper;
}
