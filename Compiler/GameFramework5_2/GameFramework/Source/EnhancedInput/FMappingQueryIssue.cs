#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputMappingQuery.h")]
///<summary>Potential issue raised with a mapping request</summary>
public partial struct FMappingQueryIssue {
// MappingQueryIssue
	public EMappingQueryIssue Issue;
	public UInputMappingContext BlockingContext;
	public UInputAction BlockingAction;
}
