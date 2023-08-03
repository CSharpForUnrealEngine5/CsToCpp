#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineObjectIdPass.h")]
public partial class UMoviePipelineObjectIdRenderPass : UMoviePipelineImagePassBase {
	public static UClass StaticClass() {return default;}
	///<summary>IdType</summary>
	public EMoviePipelineObjectIdPassIdType IdType;
	///<summary>If true, translucent objects will be included in the ObjectId pass (but as an opaque layer due to limitations). False will omit translucent objects.</summary>
	public bool bIncludeTranslucentObjects;
}
