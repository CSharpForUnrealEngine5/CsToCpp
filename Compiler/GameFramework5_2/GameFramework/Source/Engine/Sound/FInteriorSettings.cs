namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct encapsulating settings for interior areas.</summary>
[CppInclude("Sound/AudioVolume.h")]
public partial struct FInteriorSettings {
	public bool bIsWorldSettings;
	public float ExteriorVolume;
	public float ExteriorTime;
	public float ExteriorLPF;
	public float ExteriorLPFTime;
	public float InteriorVolume;
	public float InteriorTime;
	public float InteriorLPF;
	public float InteriorLPFTime;
}
