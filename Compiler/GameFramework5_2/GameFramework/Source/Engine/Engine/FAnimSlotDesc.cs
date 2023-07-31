#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to indicate each slot name and how many channels they have.</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FAnimSlotDesc {
	public string SlotName;
	public int NumChannels;
}
