namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RuntimeAssetCacheBPHooks.h")]
public partial class URuntimeAssetCacheBPHooks : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetSynchronous</summary>
	public static FVoidPtrParam GetSynchronous(object /*CacheBuilder*/ CacheBuilder) { return default; }
	///<summary>GetAsynchronous</summary>
	public static int GetAsynchronous(object /*CacheBuilder*/ CacheBuilder,FOnRuntimeAssetCacheAsyncComplete CompletionDelegate) { return default; }
	///<summary>GetCacheSize</summary>
	public static int GetCacheSize(FName Bucket) { return default; }
	///<summary>ClearCache</summary>
	public static bool ClearCache(FName Bucket) { return default; }
	///<summary>WaitAsynchronousCompletion</summary>
	public static void WaitAsynchronousCompletion(int Handle) {}
	///<summary>GetAsynchronousResults</summary>
	public static FVoidPtrParam GetAsynchronousResults(int Handle) { return default; }
	///<summary>PollAsynchronousCompletion</summary>
	public static bool PollAsynchronousCompletion(int Handle) { return default; }
}
