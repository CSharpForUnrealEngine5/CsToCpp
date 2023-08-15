namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to define information for terminal types, e.g. types that can be contained</summary>
[CppInclude("EdGraph/EdGraphNode.h")]
public partial struct FEdGraphTerminalType {
	public FName TerminalCategory;
	public FName TerminalSubCategory;
	public TWeakObjectPtr<UObject> TerminalSubCategoryObject;
	public bool bTerminalIsConst;
	public bool bTerminalIsWeakPointer;
	public bool bTerminalIsUObjectWrapper;
}
