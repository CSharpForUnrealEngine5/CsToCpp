#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassProcessor.h")]
public partial class UMassCompositeProcessor : UMassProcessor {
	///<summary>ChildPipeline</summary>
	public FMassRuntimePipeline ChildPipeline;
	///<summary>Group name that will be used when resolving processor dependencies and grouping</summary>
	public string GroupName;
}
