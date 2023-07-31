#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PlatformInterfaceBase.h")]
///<summary>An enum for the types of data used in a PlatformInterfaceData struct.</summary>
public enum EPlatformInterfaceDataType {
	PIDT_None=0,
	PIDT_Int=1,
	PIDT_Float=2,
	PIDT_String=3,
	PIDT_Object=4,
	PIDT_Custom=5,
	PIDT_MAX=6,
}
