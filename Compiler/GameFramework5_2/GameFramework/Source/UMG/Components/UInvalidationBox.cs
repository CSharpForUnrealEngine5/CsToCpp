#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Invalidate</summary>
[CppInclude("Components/InvalidationBox.h")]
public partial class UInvalidationBox : UContentWidget {
	public static UClass StaticClass() {return default;}
	///<summary>InvalidateCache</summary>
	public  void InvalidateCache() {}
	///<summary>@returns true when the invalidation box cache the widgets.</summary>
	public  bool GetCanCache() { return default; }
	///<summary>Tell the InvalidationBox to use the invalidation process.</summary>
	public  void SetCanCache(bool CanCache) {}
	///<summary>Should the invalidation panel cache the widgets?  Making this false makes it so the invalidation</summary>
	public bool bCanCache;
}
