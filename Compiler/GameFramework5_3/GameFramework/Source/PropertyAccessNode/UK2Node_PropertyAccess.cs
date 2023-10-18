namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_PropertyAccess.h")]
public partial class UK2Node_PropertyAccess : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>Path that this access exposes</summary>
	public TArray<string> Path;
	///<summary>Path as text, for display</summary>
	public FText TextPath;
	///<summary>Resolved pin type</summary>
	public FEdGraphPinType ResolvedPinType;
	///<summary>Generated property created during compilation</summary>
	public FName GeneratedPropertyName;
	///<summary>Property access context (set by the user) that is intended to be used</summary>
	public FName ContextId;
}
