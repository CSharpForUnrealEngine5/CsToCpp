#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/UserWidgetPool.h")]
///<summary>Pools UUserWidget instances to minimize UObject and SWidget allocations for UMG elements with dynamic entries.</summary>
public partial struct FUserWidgetPool {
// UserWidgetPool
	public TArray<UUserWidget> ActiveWidgets;
	public TArray<UUserWidget> InactiveWidgets;
}
