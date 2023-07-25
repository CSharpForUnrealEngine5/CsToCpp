#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/InvalidationBox.h")]
///<summary>Invalidate</summary>
public partial class UInvalidationBox : UContentWidget {
// InvalidationBox
	public void InvalidateCache() {}
	public bool GetCanCache() { return default; }
	public void SetCanCache(bool CanCache) {}
	public bool bCanCache;
}
