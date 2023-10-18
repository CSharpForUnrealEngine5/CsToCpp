namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProxyAsset.h")]
public partial class UProxyAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Type</summary>
	public UClass Type;
	///<summary>ResultType</summary>
	public EObjectChooserResultType ResultType;
	///<summary>ContextData</summary>
	public TArray<FInstancedStruct> ContextData;
	///<summary>ProxyTable</summary>
	public FInstancedStruct ProxyTable;
	///<summary>Guid</summary>
	public FGuid Guid;
	///<summary>ContextClass_DEPRECATED</summary>
	public UClass ContextClass_DEPRECATED;
}
