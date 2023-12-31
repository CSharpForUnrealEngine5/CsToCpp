namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UIFPlayerComponent.h")]
public partial class UUIFrameworkPlayerComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>AddWidget</summary>
	public void AddWidget(FUIFrameworkGameLayerSlot Widget) {}
	///<summary>RemoveWidget</summary>
	public void RemoveWidget(UUIFrameworkWidget Widget) {}
	///<summary>ServerRemoveWidgetRootFromTree</summary>
	public void ServerRemoveWidgetRootFromTree(FUIFrameworkWidgetId WidgetId) {}
	///<summary>RootList</summary>
	public FUIFrameworkGameLayerSlotList RootList;
	///<summary>WidgetTree</summary>
	public FUIFrameworkWidgetTree WidgetTree;
	///<summary>Presenter</summary>
	public UUIFrameworkPresenter Presenter;
	///<summary>NetReplicationPending</summary>
	public TSet<int> NetReplicationPending;
	///<summary>AddPending</summary>
	public TSet<int> AddPending;
}
