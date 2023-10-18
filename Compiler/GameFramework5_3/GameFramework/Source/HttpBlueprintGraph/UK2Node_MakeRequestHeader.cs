namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Node to create an Http header, with presets.</summary>
[CppInclude("K2Node_MakeRequestHeader.h")]
public partial class UK2Node_MakeRequestHeader : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>The currently selected preset index.</summary>
	public int PresetEnumIndex;
	///<summary>Number of key/value inputs.</summary>
	public int NumInputs;
	///<summary>Used to store hidden or pins to be later restored.</summary>
	public TArray<FOptionalPin> OptionalPins;
}
