namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The float fetcher is a specialized type of fetcher for the float</summary>
[CppInclude("SelectionSystem/DataprepFloatFetcher.h")]
public partial class UDataprepFloatFetcher : UDataprepFetcher {
	public static UClass StaticClass() {return default;}
	///<summary>This function is called when the fetcher is executed.</summary>
	public float Fetch(UObject Object,bool bOutFetchSucceded) { return default; }
}
