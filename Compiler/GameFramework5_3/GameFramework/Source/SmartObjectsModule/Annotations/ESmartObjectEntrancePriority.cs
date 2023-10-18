namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Annotations/SmartObjectSlotEntranceAnnotation.h")]
///<summary>Enum used to define a entrance selection priority. Highest priority is preferred, but when the priority is the same</summary>
public enum ESmartObjectEntrancePriority {
	Lowest=0,
	Lower=1,
	Low=2,
	BelowNormal=3,
	Normal=4,
	AboveNormal=5,
	High=6,
	Higher=7,
	Highest=8,
	MIN=-1,
	MAX=-1,
}
