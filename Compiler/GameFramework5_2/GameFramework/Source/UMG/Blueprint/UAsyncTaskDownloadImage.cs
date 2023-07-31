#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/AsyncTaskDownloadImage.h")]
public partial class UAsyncTaskDownloadImage : UBlueprintAsyncActionBase {
	///<summary>DownloadImage</summary>
	public static UAsyncTaskDownloadImage DownloadImage(string URL) { return default; }
	///<summary>OnSuccess</summary>
	public FDownloadImageDelegate OnSuccess;
	///<summary>OnFail</summary>
	public FDownloadImageDelegate OnFail;
}
