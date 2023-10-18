namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassProcessor.h")]
public partial class UMassCompositeProcessor : UMassProcessor {
	public static UClass StaticClass() {return default;}
	///<summary>ChildPipeline</summary>
	public FMassRuntimePipeline ChildPipeline;
	///<summary>Group name that will be used when resolving processor dependencies and grouping</summary>
	public FName GroupName;
}
