#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXControlConsoleFaderGroup.h")]
///<summary>A Group of Faders in the DMX Control Console</summary>
public partial class UDMXControlConsoleFaderGroup : UObject {
// DMXControlConsoleFaderGroup
	public string FaderGroupName;
	public TSoftObjectPtr<UDMXEntityFixturePatch> SoftFixturePatchPtr;
	public TWeakObjectPtr<UDMXEntityFixturePatch> CachedWeakFixturePatch;
	public TArray<object /*Elements*/> Elements;
	public FLinearColor EditorColor;
}
