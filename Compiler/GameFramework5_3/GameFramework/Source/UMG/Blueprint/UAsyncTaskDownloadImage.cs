namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/AsyncTaskDownloadImage.h")]
public partial class UAsyncTaskDownloadImage : UBlueprintAsyncActionBase {
	public static UClass StaticClass() {return default;}
	///<summary>DownloadImage</summary>
	public static UAsyncTaskDownloadImage DownloadImage(string URL) { return default; }
	///<summary>OnSuccess</summary>
	public FDownloadImageDelegate OnSuccess;
	///<summary>OnFail</summary>
	public FDownloadImageDelegate OnFail;
}
