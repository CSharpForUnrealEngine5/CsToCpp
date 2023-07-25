#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RuntimeAssetCacheBPHooks.h")]
public partial class URuntimeAssetCacheBPHooks : UBlueprintFunctionLibrary {
// RuntimeAssetCacheBPHooks
	public FVoidPtrParam GetSynchronous(object /*CacheBuilder*/ CacheBuilder) { return default; }
	public int GetAsynchronous(object /*CacheBuilder*/ CacheBuilder,FOnRuntimeAssetCacheAsyncComplete CompletionDelegate) { return default; }
	public int GetCacheSize(string Bucket) { return default; }
	public bool ClearCache(string Bucket) { return default; }
	public void WaitAsynchronousCompletion(int Handle) {}
	public FVoidPtrParam GetAsynchronousResults(int Handle) { return default; }
	public bool PollAsynchronousCompletion(int Handle) { return default; }
}
