#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_EditablePinBase.h")]
///<summary>This structure describes metadata associated with a user declared function or macro</summary>
public partial struct FKismetUserDeclaredFunctionMetadata {
// KismetUserDeclaredFunctionMetadata
	public string ToolTip;
	public string Category;
	public string Keywords;
	public string CompactNodeTitle;
	public FLinearColor InstanceTitleColor;
	public string DeprecationMessage;
	public bool bIsDeprecated;
	public bool bCallInEditor;
	public bool bThreadSafe;
	public bool bIsUnsafeDuringActorConstruction;
	public short HasLatentFunctions;
	public TMap<string,string> MetaDataMap;
}
