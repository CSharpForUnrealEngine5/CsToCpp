#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the UndoHistory.</summary>
[CppInclude("UndoHistorySettings.h")]
public partial class UUndoHistorySettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>True when the UndoHistory is showing transaction details.</summary>
	public bool bShowTransactionDetails;
}
