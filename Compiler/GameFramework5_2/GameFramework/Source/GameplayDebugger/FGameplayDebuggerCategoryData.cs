#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerCategoryReplicator.h")]
public partial struct FGameplayDebuggerCategoryData {
// GameplayDebuggerCategoryData
	public string CategoryName;
	public TArray<string> TextLines;
	public TArray<FGameplayDebuggerShape> Shapes;
	public TArray<FGameplayDebuggerDataPackHeader> DataPacks;
	public bool bIsEnabled;
}
