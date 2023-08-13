namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraphPin.h")]
public partial struct FEdGraphPinReference {
	public TWeakObjectPtr<UEdGraphNode> OwningNode;
	public FGuid PinId;
}
