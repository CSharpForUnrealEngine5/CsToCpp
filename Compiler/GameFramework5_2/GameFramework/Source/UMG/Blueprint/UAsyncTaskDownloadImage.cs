#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/AsyncTaskDownloadImage.h")]
public partial class UAsyncTaskDownloadImage : UBlueprintAsyncActionBase {
// AsyncTaskDownloadImage
	public static UAsyncTaskDownloadImage DownloadImage(string URL) { return default; }
	public FDownloadImageDelegate OnSuccess;
	public FDownloadImageDelegate OnFail;
}
