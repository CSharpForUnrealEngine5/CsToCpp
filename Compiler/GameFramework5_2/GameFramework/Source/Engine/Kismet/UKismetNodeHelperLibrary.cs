#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetNodeHelperLibrary.h")]
public partial class UKismetNodeHelperLibrary : UBlueprintFunctionLibrary {
// KismetNodeHelperLibrary
	public bool BitIsMarked(int Data,int Index) { return default; }
	public void MarkBit(int Data,int Index) {}
	public void ClearBit(int Data,int Index) {}
	public void ClearAllBits(int Data) {}
	public bool HasUnmarkedBit(int Data,int NumBits) { return default; }
	public bool HasMarkedBit(int Data,int NumBits) { return default; }
	public int GetUnmarkedBit(int Data,int StartIdx,int NumBits,bool bRandom) { return default; }
	public int GetRandomUnmarkedBit(int Data,int StartIdx,int NumBits) { return default; }
	public int GetFirstUnmarkedBit(int Data,int StartIdx,int NumBits) { return default; }
	public string GetEnumeratorName(UObject Enum,byte EnumeratorValue) { return default; }
	public string GetEnumeratorUserFriendlyName(UObject Enum,byte EnumeratorValue) { return default; }
	public byte GetValidValue(UObject Enum,byte EnumeratorValue) { return default; }
	public byte GetEnumeratorValueFromIndex(UObject Enum,byte EnumeratorIndex) { return default; }
}
