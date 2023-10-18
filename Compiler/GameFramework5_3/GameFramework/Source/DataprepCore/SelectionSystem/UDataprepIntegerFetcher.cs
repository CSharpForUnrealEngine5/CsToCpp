namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The integer fetcher is a specialized type of fetcher for the integer</summary>
[CppInclude("SelectionSystem/DataprepIntegerFetcher.h")]
public partial class UDataprepIntegerFetcher : UDataprepFetcher {
	public static UClass StaticClass() {return default;}
	///<summary>This function is called when the fetcher is executed.</summary>
	public int Fetch(UObject Object,bool bOutFetchSucceded) { return default; }
}
