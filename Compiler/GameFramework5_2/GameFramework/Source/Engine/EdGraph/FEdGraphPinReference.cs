#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraphPin.h")]
public partial struct FEdGraphPinReference {
// EdGraphPinReference
	public TWeakObjectPtr<UEdGraphNode> OwningNode;
	public FGuid PinId;
}
