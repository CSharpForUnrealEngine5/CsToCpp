namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Quality of indirect lighting for Movable primitives. This has a large effect on Indirect Lighting Cache update time.</summary>
public enum EIndirectLightingCacheQuality {
	ILCQ_Off=0,
	ILCQ_Point=1,
	ILCQ_Volume=2,
}
