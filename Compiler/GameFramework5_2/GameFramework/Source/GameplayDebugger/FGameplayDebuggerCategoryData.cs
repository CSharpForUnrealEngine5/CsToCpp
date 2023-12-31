namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerCategoryReplicator.h")]
public partial struct FGameplayDebuggerCategoryData {
	public FName CategoryName;
	public TArray<string> TextLines;
	public TArray<FGameplayDebuggerShape> Shapes;
	public TArray<FGameplayDebuggerDataPackHeader> DataPacks;
	public bool bIsEnabled;
}
