#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RuntimeAssetCacheBPHooks.h")]
public partial class URuntimeAssetCacheBPHooks : UBlueprintFunctionLibrary {
// RuntimeAssetCacheBPHooks
	public static FVoidPtrParam GetSynchronous(object /*CacheBuilder*/ CacheBuilder) { return default; }
	public static int GetAsynchronous(object /*CacheBuilder*/ CacheBuilder,FOnRuntimeAssetCacheAsyncComplete CompletionDelegate) { return default; }
	public static int GetCacheSize(string Bucket) { return default; }
	public static bool ClearCache(string Bucket) { return default; }
	public static void WaitAsynchronousCompletion(int Handle) {}
	public static FVoidPtrParam GetAsynchronousResults(int Handle) { return default; }
	public static bool PollAsynchronousCompletion(int Handle) { return default; }
}
