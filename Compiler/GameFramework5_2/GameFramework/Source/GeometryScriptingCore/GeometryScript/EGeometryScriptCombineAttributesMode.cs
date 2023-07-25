#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBasicEditFunctions.h")]
///<summary>Options for how attributes from a source and target mesh are combined into the target mesh</summary>
public enum EGeometryScriptCombineAttributesMode {
	EnableAllMatching=0,
	UseTarget=1,
	UseSource=2,
}
