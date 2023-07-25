#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
///<summary>TODO: Custom will eventually mean that the default value or binding will be overridden by a subgraph default, i.e. expose it to a "Initialize variable" node.</summary>
public enum ENiagaraDefaultMode {
	Value=0,
	Binding=1,
	Custom=2,
	FailIfPreviouslyNotSet=3,
}
