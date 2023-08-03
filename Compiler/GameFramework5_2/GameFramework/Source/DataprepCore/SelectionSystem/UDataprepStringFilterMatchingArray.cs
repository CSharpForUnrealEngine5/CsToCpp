#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepStringFilter.h")]
public partial class UDataprepStringFilterMatchingArray : UDataprepParameterizableObject {
	public static UClass StaticClass() {return default;}
	///<summary>Strings</summary>
	public TArray<string> Strings;
	///<summary>UI state that needs to be serialized along with string values</summary>
	public bool bExpanded;
}
