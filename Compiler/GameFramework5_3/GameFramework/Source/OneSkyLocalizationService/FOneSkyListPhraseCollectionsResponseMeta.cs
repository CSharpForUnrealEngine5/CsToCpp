namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>LIST PHRASE COLLECTIONS</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyListPhraseCollectionsResponseMeta {
	public int status;
	public int record_count;
	public int page_count;
	public string next_page;
	public string prev_page;
	public string first_page;
	public string last_page;
}
