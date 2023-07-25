#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraphNode.h")]
///<summary>Struct used to define information for terminal types, e.g. types that can be contained</summary>
public partial struct FEdGraphTerminalType {
// EdGraphTerminalType
	public string TerminalCategory;
	public string TerminalSubCategory;
	public TWeakObjectPtr<UObject> TerminalSubCategoryObject;
	public bool bTerminalIsConst;
	public bool bTerminalIsWeakPointer;
	public bool bTerminalIsUObjectWrapper;
}
