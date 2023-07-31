#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGDataFromActor.h")]
public enum EPCGGetDataFromActorMode {
	ParseActorComponents=0,
	GetSinglePoint=1,
	GetDataFromProperty=2,
	GetDataFromPCGComponent=3,
	GetDataFromPCGComponentOrParseComponents=4,
}
