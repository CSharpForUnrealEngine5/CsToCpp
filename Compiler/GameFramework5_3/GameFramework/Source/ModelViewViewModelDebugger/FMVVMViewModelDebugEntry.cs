namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMDebugViewModel.h")]
public partial struct FMVVMViewModelDebugEntry {
	public FName Name;
	public string PathName;
	public FAssetData ViewModelAsset;
	public TArray<FMVVMViewModelFieldBoundDebugEntry> FieldBound;
	public FGuid ViewModelDebugId;
}
