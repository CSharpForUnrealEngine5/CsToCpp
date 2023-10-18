namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements base logic to keep group names unique within a hierachy</summary>
[CppInclude("Hierarchies/BaseModifierGroup.h")]
public partial class UBaseModifierGroup : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>NodeName</summary>
	public FName NodeName;
}
