namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filter objects based on the key value of their metadata.</summary>
[CppInclude("DatasmithDataprepFetcher.h")]
public partial class UDatasmithStringMetadataValueFetcher : UDataprepStringsArrayFetcher {
	public static UClass StaticClass() {return default;}
	///<summary>KeyMatch</summary>
	public EMetadataKeyMatchingCriteria KeyMatch;
	///<summary>The key for the for the string</summary>
	public FName Key;
}
