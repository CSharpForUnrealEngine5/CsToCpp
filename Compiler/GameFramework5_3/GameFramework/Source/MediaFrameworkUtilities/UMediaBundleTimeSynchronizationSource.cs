namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Synchronization Source using the Media Bundle</summary>
[CppInclude("MediaBundleTimeSynchronizationSource.h")]
public partial class UMediaBundleTimeSynchronizationSource : UTimeSynchronizationSource {
	public static UClass StaticClass() {return default;}
	///<summary>Media bundle asset of this input</summary>
	public UMediaBundle MediaBundle;
}
