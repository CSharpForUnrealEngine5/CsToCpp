namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMDebugView.h")]
public partial struct FMVVMViewDebugEntry {
	public FName UserWidgetInstanceName;
	public FName LocalPlayerName;
	public FName WorldName;
	public FAssetData UserWidgetAsset;
	public TArray<FMVVMViewSourceDebugEntry> Sources;
	public FGuid ViewClassDebugId;
	public FGuid ViewInstanceDebugId;
}
