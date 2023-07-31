#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyListUploadedFilesResponseDataItem {
	public string file_name;
	public int string_count;
	public FOneSkyListUploadedFilesResponseLastImport last_import;
	public string uploaded_at;
	public int uploaded_at_timestamp;
}
