namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_Select.h")]
public partial class UK2Node_Select : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>The number of selectable options this node currently has</summary>
	public int NumOptionPins;
	///<summary>The pin type of the index pin</summary>
	public FEdGraphPinType IndexPinType;
	///<summary>Name of the enum being switched on</summary>
	public UEnum Enum;
	///<summary>List of the current entries in the enum (Pin Names)</summary>
	public TArray<string> EnumEntries;
	///<summary>List of the current entries in the enum (Pin Friendly Names)</summary>
	public TArray<FText> EnumEntryFriendlyNames;
	///<summary>Whether we need to reconstruct the node after the pins have changed</summary>
	public bool bReconstructNode;
}
