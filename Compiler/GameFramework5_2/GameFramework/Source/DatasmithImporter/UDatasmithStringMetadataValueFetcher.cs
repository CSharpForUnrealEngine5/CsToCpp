#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filter objects based on the key value of their metadata.</summary>
[CppInclude("DatasmithDataprepFetcher.h")]
public partial class UDatasmithStringMetadataValueFetcher : UDataprepStringsArrayFetcher {
	///<summary>KeyMatch</summary>
	public EMetadataKeyMatchingCriteria KeyMatch;
	///<summary>The key for the for the string</summary>
	public string Key;
}
