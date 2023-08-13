namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This AInfos enable you to define a correspondance between the UE origin and an actual geographic location on a planet</summary>
[CppInclude("GeoReferencingSystem.h")]
public partial class AGeoReferencingSystem : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>GetGeoReferencingSystem</summary>
	public static AGeoReferencingSystem GetGeoReferencingSystem(UObject WorldContextObject) { return default; }
	///<summary>EngineToProjected</summary>
	public void EngineToProjected(FVector EngineCoordinates,FCartesianCoordinates ProjectedCoordinates) {}
	///<summary>ProjectedToEngine</summary>
	public void ProjectedToEngine(FCartesianCoordinates ProjectedCoordinates,FVector EngineCoordinates) {}
	///<summary>EngineToECEF</summary>
	public void EngineToECEF(FVector EngineCoordinates,FCartesianCoordinates ECEFCoordinates) {}
	///<summary>ECEFToEngine</summary>
	public void ECEFToEngine(FCartesianCoordinates ECEFCoordinates,FVector EngineCoordinates) {}
	///<summary>ProjectedToGeographic</summary>
	public void ProjectedToGeographic(FCartesianCoordinates ProjectedCoordinates,FGeographicCoordinates GeographicCoordinates) {}
	///<summary>GeographicToProjected</summary>
	public void GeographicToProjected(FGeographicCoordinates GeographicCoordinates,FCartesianCoordinates ProjectedCoordinates) {}
	///<summary>ProjectedToECEF</summary>
	public void ProjectedToECEF(FCartesianCoordinates ProjectedCoordinates,FCartesianCoordinates ECEFCoordinates) {}
	///<summary>ECEFToProjected</summary>
	public void ECEFToProjected(FCartesianCoordinates ECEFCoordinates,FCartesianCoordinates ProjectedCoordinates) {}
	///<summary>GeographicToECEF</summary>
	public void GeographicToECEF(FGeographicCoordinates GeographicCoordinates,FCartesianCoordinates ECEFCoordinates) {}
	///<summary>ECEFToGeographic</summary>
	public void ECEFToGeographic(FCartesianCoordinates ECEFCoordinates,FGeographicCoordinates GeographicCoordinates) {}
	///<summary>GetENUVectorsAtProjectedLocation</summary>
	public void GetENUVectorsAtProjectedLocation(FCartesianCoordinates ProjectedCoordinates,FVector East,FVector North,FVector Up) {}
	///<summary>GetENUVectorsAtECEFLocation</summary>
	public void GetENUVectorsAtECEFLocation(FCartesianCoordinates ECEFCoordinates,FVector East,FVector North,FVector Up) {}
	///<summary>GetECEFENUVectorsAtECEFLocation</summary>
	public void GetECEFENUVectorsAtECEFLocation(FCartesianCoordinates ECEFCoordinates,FVector ECEFEast,FVector ECEFNorth,FVector ECEFUp) {}
	///<summary>GetTangentTransformAtProjectedLocation</summary>
	public FTransform GetTangentTransformAtProjectedLocation(FCartesianCoordinates ProjectedCoordinates) { return default; }
	///<summary>GetTangentTransformAtECEFLocation</summary>
	public FTransform GetTangentTransformAtECEFLocation(FCartesianCoordinates ECEFCoordinates) { return default; }
	///<summary>Convert a Vector expressed in ENGINE space to the PROJECTED CRS</summary>
	public void K2_EngineToProjected(FVector EngineCoordinates,FVector ProjectedCoordinates) {}
	///<summary>Convert a Vector expressed in PROJECTED CRS to ENGINE space</summary>
	public void K2_ProjectedToEngine(FVector ProjectedCoordinates,FVector EngineCoordinates) {}
	///<summary>Convert a Vector expressed in ENGINE space to the ECEF CRS</summary>
	public void K2_EngineToECEF(FVector EngineCoordinates,FVector ECEFCoordinates) {}
	///<summary>Convert a Vector expressed in ECEF CRS to ENGINE space</summary>
	public void K2_ECEFToEngine(FVector ECEFCoordinates,FVector EngineCoordinates) {}
	///<summary>Convert a Coordinate expressed in PROJECTED CRS to GEOGRAPHIC CRS</summary>
	public void K2_ProjectedToGeographic(FVector ProjectedCoordinates,FGeographicCoordinates GeographicCoordinates) {}
	///<summary>Convert a Coordinate expressed in GEOGRAPHIC CRS to PROJECTED CRS</summary>
	public void K2_GeographicToProjected(FGeographicCoordinates GeographicCoordinates,FVector ProjectedCoordinates) {}
	///<summary>Convert a Coordinate expressed in PROJECTED CRS to ECEF CRS</summary>
	public void K2_ProjectedToECEF(FVector ProjectedCoordinates,FVector ECEFCoordinates) {}
	///<summary>Convert a Coordinate expressed in ECEF CRS to PROJECTED CRS</summary>
	public void K2_ECEFToProjected(FVector ECEFCoordinates,FVector ProjectedCoordinates) {}
	///<summary>Convert a Coordinate expressed in GEOGRAPHIC CRS to ECEF CRS</summary>
	public void K2_GeographicToECEF(FGeographicCoordinates GeographicCoordinates,FVector ECEFCoordinates) {}
	///<summary>Convert a Coordinate expressed in ECEF CRS to GEOGRAPHIC CRS</summary>
	public void K2_ECEFToGeographic(FVector ECEFCoordinates,FGeographicCoordinates GeographicCoordinates) {}
	///<summary>Get the East North Up vectors at a specific location</summary>
	public void K2_GetENUVectorsAtProjectedLocation(FVector ProjectedCoordinates,FVector East,FVector North,FVector Up) {}
	///<summary>Get the East North Up vectors at a specific location</summary>
	public void K2_GetENUVectorsAtECEFLocation(FVector ECEFCoordinates,FVector East,FVector North,FVector Up) {}
	///<summary>Get the East North Up vectors at a specific location - Not in engine frame, but in pure ECEF Frame !</summary>
	public void K2_GetECEFENUVectorsAtECEFLocation(FVector ECEFCoordinates,FVector ECEFEast,FVector ECEFNorth,FVector ECEFUp) {}
	///<summary>Get the the transform to locate an object tangent to Ellipsoid at a specific location</summary>
	public FTransform K2_GetTangentTransformAtProjectedLocation(FVector ProjectedCoordinates) { return default; }
	///<summary>Get the the transform to locate an object tangent to Ellipsoid at a specific location</summary>
	public FTransform K2_GetTangentTransformAtECEFLocation(FVector ECEFCoordinates) { return default; }
	///<summary>Convert a Vector expressed in ENGINE space to the GEOGRAPHIC CRS</summary>
	public void EngineToGeographic(FVector EngineCoordinates,FGeographicCoordinates GeographicCoordinates) {}
	///<summary>Convert a Vector expressed in GEOGRAPHIC CRS to ENGINE space</summary>
	public void GeographicToEngine(FGeographicCoordinates GeographicCoordinates,FVector EngineCoordinates) {}
	///<summary>Get the East North Up vectors at a specific location</summary>
	public void GetENUVectorsAtEngineLocation(FVector EngineCoordinates,FVector East,FVector North,FVector Up) {}
	///<summary>Get the East North Up vectors at a specific location</summary>
	public void GetENUVectorsAtGeographicLocation(FGeographicCoordinates GeographicCoordinates,FVector East,FVector North,FVector Up) {}
	///<summary>Get the the transform to locate an object tangent to Ellipsoid at a specific location</summary>
	public FTransform GetTangentTransformAtEngineLocation(FVector EngineCoordinates) { return default; }
	///<summary>Get the the transform to locate an object tangent to Ellipsoid at a specific location</summary>
	public FTransform GetTangentTransformAtGeographicLocation(FGeographicCoordinates GeographicCoordinates) { return default; }
	///<summary>Set this transform to an Ellipsoid to have it positioned tangent to the origin.</summary>
	public FTransform GetPlanetCenterTransform() { return default; }
	///<summary>Check if the string corresponds to a valid CRS descriptor</summary>
	public bool IsCRSStringValid(string CRSString,string Error) { return default; }
	///<summary>Find the underlying Geographic CRS Ellipsoid and return its maximum radius</summary>
	public double GetGeographicEllipsoidMaxRadius() { return default; }
	///<summary>Find the underlying Geographic CRS Ellipsoid and return its minimum radius</summary>
	public double GetGeographicEllipsoidMinRadius() { return default; }
	///<summary>Find the underlying Projected CRS Ellipsoid and return its maximum radius</summary>
	public double GetProjectedEllipsoidMaxRadius() { return default; }
	///<summary>Find the underlying Projected CRS Ellipsoid and return its minimum radius</summary>
	public double GetProjectedEllipsoidMinRadius() { return default; }
	///<summary>In case you want to change the Origin or CRS definition properties during application execution, you need to call this function to update the internal transformation cache.</summary>
	public void ApplySettings() {}
	///<summary>This mode has to be set consistently with the way you authored your ground geometry.</summary>
	public EPlanetShape PlanetShape;
	///<summary>String that describes the PROJECTED CRS of choice.</summary>
	public string ProjectedCRS;
	///<summary>String that describes the GEOGRAPHIC CRS of choice.</summary>
	public string GeographicCRS;
	///<summary>if true, the UE origin is located at the Planet Center, otherwise,</summary>
	public bool bOriginAtPlanetCenter;
	///<summary>if true, the UE origin georeference is expressed in the PROJECTED CRS.</summary>
	public bool bOriginLocationInProjectedCRS;
	///<summary>Latitude of UE Origin on planet</summary>
	public double OriginLatitude;
	///<summary>Longitude of UE Origin on planet</summary>
	public double OriginLongitude;
	///<summary>Altitude of UE Origin on planet</summary>
	public double OriginAltitude;
	///<summary>Easting position of UE Origin on planet, express in the Projected CRS Frame</summary>
	public double OriginProjectedCoordinatesEasting;
	///<summary>Northing position of UE Origin on planet, express in the Projected CRS Frame</summary>
	public double OriginProjectedCoordinatesNorthing;
	///<summary>Up position of UE Origin on planet, express in the Projected CRS Frame</summary>
	public double OriginProjectedCoordinatesUp;
}
