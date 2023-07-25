#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/WidgetSnapshots.h")]
///<summary>Saves a subset of properties of a widget.</summary>
public partial struct FWidgetSnapshot {
// WidgetSnapshot
	public UClass WidgetClass;
	public TArray<byte> SavedBinaryData;
}
