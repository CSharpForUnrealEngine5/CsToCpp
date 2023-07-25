#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Specifies what types of objects to return from an overlap physics query</summary>
public enum EOverlapFilterOption {
	OverlapFilter_All=0,
	OverlapFilter_DynamicOnly=1,
	OverlapFilter_StaticOnly=2,
}
