namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DestructibleMesh.h")]
///<summary>Chunks up to the depth DefaultImpactDamageDepth will take impact damage, unless IDO_On or IDO_Off is chosen.</summary>
public enum EImpactDamageOverride {
	IDO_None=0,
	IDO_On=1,
	IDO_Off=2,
	IDO_MAX=3,
}
