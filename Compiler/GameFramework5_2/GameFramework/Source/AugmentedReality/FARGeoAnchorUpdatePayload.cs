#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARGeoAnchorUpdatePayload {
// ARGeoAnchorUpdatePayload
	public FARSessionPayload SessionPayload;
	public FTransform WorldTransform;
	public float Longitude;
	public float Latitude;
	public float AltitudeMeters;
	public EARAltitudeSource AltitudeSource;
	public string AnchorName;
}
