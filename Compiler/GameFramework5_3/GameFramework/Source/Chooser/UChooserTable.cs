namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chooser.h")]
public partial class UChooserTable : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>deprecated UObject Results</summary>
	public TArray<object /*Results_DEPRECATED*/> Results_DEPRECATED;
	///<summary>deprecated single context object</summary>
	public UClass ContextObjectType_DEPRECATED;
	///<summary>deprecated UObject Columns</summary>
	public TArray<object /*Columns_DEPRECATED*/> Columns_DEPRECATED;
	///<summary>Each possible Result (Rows of chooser table)</summary>
	public TArray<FInstancedStruct> ResultsStructs;
	///<summary>Columns which filter Results</summary>
	public TArray<FInstancedStruct> ColumnsStructs;
	///<summary>ContextData</summary>
	public TArray<FInstancedStruct> ContextData;
	///<summary>OutputObjectType</summary>
	public UClass OutputObjectType;
	///<summary>ResultType</summary>
	public EObjectChooserResultType ResultType;
}
