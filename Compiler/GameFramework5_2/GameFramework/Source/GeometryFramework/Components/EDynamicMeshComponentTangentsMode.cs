namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/BaseDynamicMeshComponent.h")]
///<summary>Tangent calculation modes</summary>
public enum EDynamicMeshComponentTangentsMode {
	NoTangents=0,
	AutoCalculated=1,
	ExternallyProvided=2,
}
