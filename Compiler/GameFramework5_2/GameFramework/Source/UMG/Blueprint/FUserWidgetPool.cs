namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pools UUserWidget instances to minimize UObject and SWidget allocations for UMG elements with dynamic entries.</summary>
[CppInclude("Blueprint/UserWidgetPool.h")]
public partial struct FUserWidgetPool {
	public TArray<UUserWidget> ActiveWidgets;
	public TArray<UUserWidget> InactiveWidgets;
}
