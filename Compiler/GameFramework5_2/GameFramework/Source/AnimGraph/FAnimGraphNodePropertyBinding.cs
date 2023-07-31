#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_Base.h")]
public partial struct FAnimGraphNodePropertyBinding {
	public FEdGraphPinType PinType;
	public FEdGraphPinType PromotedPinType;
	public string PropertyName;
	public int ArrayIndex;
	public string PathAsText;
	public TArray<string> PropertyPath;
	public string ContextId;
	public string CompiledContext;
	public string CompiledContextDesc;
	public EAnimGraphNodePropertyBindingType Type;
	public bool bIsBound;
	public bool bIsPromotion;
}
