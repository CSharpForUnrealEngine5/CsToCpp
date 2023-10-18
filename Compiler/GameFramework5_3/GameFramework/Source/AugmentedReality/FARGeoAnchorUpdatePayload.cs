namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
public partial struct FARGeoAnchorUpdatePayload {
	public FARSessionPayload SessionPayload;
	public FTransform WorldTransform;
	public float Longitude;
	public float Latitude;
	public float AltitudeMeters;
	public EARAltitudeSource AltitudeSource;
	public string AnchorName;
}
