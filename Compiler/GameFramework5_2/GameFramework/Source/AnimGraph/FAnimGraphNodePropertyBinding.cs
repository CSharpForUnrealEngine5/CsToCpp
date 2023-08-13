namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_Base.h")]
public partial struct FAnimGraphNodePropertyBinding {
	public FEdGraphPinType PinType;
	public FEdGraphPinType PromotedPinType;
	public string PropertyName;
	public int ArrayIndex;
	public FText PathAsText;
	public TArray<string> PropertyPath;
	public string ContextId;
	public FText CompiledContext;
	public FText CompiledContextDesc;
	public EAnimGraphNodePropertyBindingType Type;
	public bool bIsBound;
	public bool bIsPromotion;
}
