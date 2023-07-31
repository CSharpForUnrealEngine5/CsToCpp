#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraphPin.h")]
public partial struct FEdGraphPinReference {
	public TWeakObjectPtr<UEdGraphNode> OwningNode;
	public FGuid PinId;
}
