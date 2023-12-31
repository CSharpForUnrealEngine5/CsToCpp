namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Extend type conversions to handle FDropTimecode structure</summary>
[CppInclude("LinearTimecodeComponent.h")]
public partial class UDropTimecodeToStringConversion : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Convert a timecode structure into a string</summary>
	public static string Conv_DropTimecodeToString(FDropTimecode InTimecode) { return default; }
}
