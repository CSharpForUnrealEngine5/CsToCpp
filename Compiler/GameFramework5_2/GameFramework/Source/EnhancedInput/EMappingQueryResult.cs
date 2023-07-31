#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputMappingQuery.h")]
///<summary>Result summary from a QueryMapKeyIn... call</summary>
public enum EMappingQueryResult {
	Error_EnhancedInputNotEnabled=0,
	Error_InputContextNotInActiveContexts=1,
	Error_InvalidAction=2,
	NotMappable=3,
	MappingAvailable=4,
}
