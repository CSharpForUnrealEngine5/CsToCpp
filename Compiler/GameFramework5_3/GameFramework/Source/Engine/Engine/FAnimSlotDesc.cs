namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to indicate each slot name and how many channels they have.</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FAnimSlotDesc {
	public FName SlotName;
	public int NumChannels;
}
