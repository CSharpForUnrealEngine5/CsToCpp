#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>LIST UPLOADED FILES</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyListUploadedFilesResponseMeta {
	public int status;
	public int record_count;
	public int page_count;
	public string next_page;
	public string prev_page;
	public string first_page;
	public string last_page;
}
