namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filter objects based of their selected class.</summary>
[CppInclude("Fetchers/DataprepBoolFetcherLibrary.h")]
public partial class UDataprepIsClassOfFetcher : UDataprepBoolFetcher {
	public static UClass StaticClass() {return default;}
	///<summary>The key for the for the string</summary>
	public UClass Class;
	///<summary>bShouldIncludeChildClass</summary>
	public bool bShouldIncludeChildClass;
}
