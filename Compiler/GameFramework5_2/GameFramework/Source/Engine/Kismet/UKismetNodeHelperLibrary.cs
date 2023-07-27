#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetNodeHelperLibrary.h")]
public partial class UKismetNodeHelperLibrary : UBlueprintFunctionLibrary {
// KismetNodeHelperLibrary
	public static bool BitIsMarked(int Data,int Index) { return default; }
	public static void MarkBit(int Data,int Index) {}
	public static void ClearBit(int Data,int Index) {}
	public static void ClearAllBits(int Data) {}
	public static bool HasUnmarkedBit(int Data,int NumBits) { return default; }
	public static bool HasMarkedBit(int Data,int NumBits) { return default; }
	public static int GetUnmarkedBit(int Data,int StartIdx,int NumBits,bool bRandom) { return default; }
	public static int GetRandomUnmarkedBit(int Data,int StartIdx,int NumBits) { return default; }
	public static int GetFirstUnmarkedBit(int Data,int StartIdx,int NumBits) { return default; }
	public static string GetEnumeratorName(UEnum Enum,byte EnumeratorValue) { return default; }
	public static string GetEnumeratorUserFriendlyName(UEnum Enum,byte EnumeratorValue) { return default; }
	public static byte GetValidValue(UEnum Enum,byte EnumeratorValue) { return default; }
	public static byte GetEnumeratorValueFromIndex(UEnum Enum,byte EnumeratorIndex) { return default; }
}
