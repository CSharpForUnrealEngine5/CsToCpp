namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BuoyancyManager.h")]
public partial class ABuoyancyManager : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>GetBuoyancyComponentManager</summary>
	public static bool GetBuoyancyComponentManager(UObject WorldContextObject,ABuoyancyManager Manager) { return default; }
	///<summary>BuoyancyComponents</summary>
	public TArray<UBuoyancyComponent> BuoyancyComponents;
}
