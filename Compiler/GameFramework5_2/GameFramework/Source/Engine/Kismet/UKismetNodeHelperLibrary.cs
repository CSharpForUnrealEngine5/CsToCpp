#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetNodeHelperLibrary.h")]
public partial class UKismetNodeHelperLibrary : UBlueprintFunctionLibrary {
	///<summary>Returns whether the bit at index &quot;Index&quot; is set or not in the data</summary>
	public static bool BitIsMarked(int Data,int Index) { return default; }
	///<summary>Sets the bit at index &quot;Index&quot; in the data</summary>
	public static void MarkBit(int Data,int Index) {}
	///<summary>Clears the bit at index &quot;Index&quot; in the data</summary>
	public static void ClearBit(int Data,int Index) {}
	///<summary>Clears all of the bit in the data</summary>
	public static void ClearAllBits(int Data) {}
	///<summary>Returns whether there exists an unmarked bit in the data</summary>
	public static bool HasUnmarkedBit(int Data,int NumBits) { return default; }
	///<summary>Returns whether there exists a marked bit in the data</summary>
	public static bool HasMarkedBit(int Data,int NumBits) { return default; }
	///<summary>Gets an already unmarked bit and returns the bit index selected</summary>
	public static int GetUnmarkedBit(int Data,int StartIdx,int NumBits,bool bRandom) { return default; }
	///<summary>Gets a random not already marked bit and returns the bit index selected</summary>
	public static int GetRandomUnmarkedBit(int Data,int StartIdx,int NumBits) { return default; }
	///<summary>Gets the first index not already marked starting from a specific index and returns the bit index selected</summary>
	public static int GetFirstUnmarkedBit(int Data,int StartIdx,int NumBits) { return default; }
	///<summary>Gets enumerator name.</summary>
	public static string GetEnumeratorName(UEnum Enum,byte EnumeratorValue) { return default; }
	///<summary>Gets enumerator name as FString. Use DeisplayName when possible.</summary>
	public static string GetEnumeratorUserFriendlyName(UEnum Enum,byte EnumeratorValue) { return default; }
	///<summary>@param Enum - Enumeration</summary>
	public static byte GetValidValue(UEnum Enum,byte EnumeratorValue) { return default; }
	///<summary>@param Enum - Enumeration</summary>
	public static byte GetEnumeratorValueFromIndex(UEnum Enum,byte EnumeratorIndex) { return default; }
}
