#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UIFPlayerComponent.h")]
public partial class UUIFrameworkPlayerComponent : UActorComponent {
// UIFrameworkPlayerComponent
	public void AddWidget(FUIFrameworkGameLayerSlot Widget) {}
	public void RemoveWidget(UObject Widget) {}
	public void ServerRemoveWidgetRootFromTree(FUIFrameworkWidgetId WidgetId) {}
	public FUIFrameworkGameLayerSlotList RootList;
	public FUIFrameworkWidgetTree WidgetTree;
	public UUIFrameworkPresenter Presenter;
	public TSet<int> NetReplicationPending;
	public TSet<int> AddPending;
}
