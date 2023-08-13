namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Potential issue raised with a mapping request</summary>
[CppInclude("InputMappingQuery.h")]
public partial struct FMappingQueryIssue {
	public EMappingQueryIssue Issue;
	public UInputMappingContext BlockingContext;
	public UInputAction BlockingAction;
}
