#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chooser.h")]
public partial class UChooserTable : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>deprecated UObject Results</summary>
	public TArray<object /*Results_DEPRECATED*/> Results_DEPRECATED;
	///<summary>deprecated UObject Columns</summary>
	public TArray<object /*Columns_DEPRECATED*/> Columns_DEPRECATED;
	///<summary>Each possible Result (Rows of chooser table)</summary>
	public TArray<FInstancedStruct> ResultsStructs;
	///<summary>Columns which filter Results</summary>
	public TArray<FInstancedStruct> ColumnsStructs;
	///<summary>ContextObjectType</summary>
	public UClass ContextObjectType;
	///<summary>OutputObjectType</summary>
	public UClass OutputObjectType;
}
