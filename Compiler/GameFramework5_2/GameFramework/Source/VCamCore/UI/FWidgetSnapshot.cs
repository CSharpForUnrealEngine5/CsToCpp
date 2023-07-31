#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Saves a subset of properties of a widget.</summary>
[CppInclude("UI/WidgetSnapshots.h")]
public partial struct FWidgetSnapshot {
	public UClass WidgetClass;
	public TArray<byte> SavedBinaryData;
}
