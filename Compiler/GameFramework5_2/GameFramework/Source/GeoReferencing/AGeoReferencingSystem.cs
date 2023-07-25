#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeoReferencingSystem.h")]
///<summary>This AInfos enable you to define a correspondance between the UE origin and an actual geographic location on a planet</summary>
public partial class AGeoReferencingSystem : AInfo {
// GeoReferencingSystem
	public UObject GetGeoReferencingSystem(UObject WorldContextObject) { return default; }
	public void EngineToProjected(FVector EngineCoordinates,FCartesianCoordinates ProjectedCoordinates) {}
	public void ProjectedToEngine(FCartesianCoordinates ProjectedCoordinates,FVector EngineCoordinates) {}
	public void EngineToECEF(FVector EngineCoordinates,FCartesianCoordinates ECEFCoordinates) {}
	public void ECEFToEngine(FCartesianCoordinates ECEFCoordinates,FVector EngineCoordinates) {}
	public void ProjectedToGeographic(FCartesianCoordinates ProjectedCoordinates,FGeographicCoordinates GeographicCoordinates) {}
	public void GeographicToProjected(FGeographicCoordinates GeographicCoordinates,FCartesianCoordinates ProjectedCoordinates) {}
	public void ProjectedToECEF(FCartesianCoordinates ProjectedCoordinates,FCartesianCoordinates ECEFCoordinates) {}
	public void ECEFToProjected(FCartesianCoordinates ECEFCoordinates,FCartesianCoordinates ProjectedCoordinates) {}
	public void GeographicToECEF(FGeographicCoordinates GeographicCoordinates,FCartesianCoordinates ECEFCoordinates) {}
	public void ECEFToGeographic(FCartesianCoordinates ECEFCoordinates,FGeographicCoordinates GeographicCoordinates) {}
	public void GetENUVectorsAtProjectedLocation(FCartesianCoordinates ProjectedCoordinates,FVector East,FVector North,FVector Up) {}
	public void GetENUVectorsAtECEFLocation(FCartesianCoordinates ECEFCoordinates,FVector East,FVector North,FVector Up) {}
	public void GetECEFENUVectorsAtECEFLocation(FCartesianCoordinates ECEFCoordinates,FVector ECEFEast,FVector ECEFNorth,FVector ECEFUp) {}
	public FTransform GetTangentTransformAtProjectedLocation(FCartesianCoordinates ProjectedCoordinates) { return default; }
	public FTransform GetTangentTransformAtECEFLocation(FCartesianCoordinates ECEFCoordinates) { return default; }
	public void K2_EngineToProjected(FVector EngineCoordinates,FVector ProjectedCoordinates) {}
	public void K2_ProjectedToEngine(FVector ProjectedCoordinates,FVector EngineCoordinates) {}
	public void K2_EngineToECEF(FVector EngineCoordinates,FVector ECEFCoordinates) {}
	public void K2_ECEFToEngine(FVector ECEFCoordinates,FVector EngineCoordinates) {}
	public void K2_ProjectedToGeographic(FVector ProjectedCoordinates,FGeographicCoordinates GeographicCoordinates) {}
	public void K2_GeographicToProjected(FGeographicCoordinates GeographicCoordinates,FVector ProjectedCoordinates) {}
	public void K2_ProjectedToECEF(FVector ProjectedCoordinates,FVector ECEFCoordinates) {}
	public void K2_ECEFToProjected(FVector ECEFCoordinates,FVector ProjectedCoordinates) {}
	public void K2_GeographicToECEF(FGeographicCoordinates GeographicCoordinates,FVector ECEFCoordinates) {}
	public void K2_ECEFToGeographic(FVector ECEFCoordinates,FGeographicCoordinates GeographicCoordinates) {}
	public void K2_GetENUVectorsAtProjectedLocation(FVector ProjectedCoordinates,FVector East,FVector North,FVector Up) {}
	public void K2_GetENUVectorsAtECEFLocation(FVector ECEFCoordinates,FVector East,FVector North,FVector Up) {}
	public void K2_GetECEFENUVectorsAtECEFLocation(FVector ECEFCoordinates,FVector ECEFEast,FVector ECEFNorth,FVector ECEFUp) {}
	public FTransform K2_GetTangentTransformAtProjectedLocation(FVector ProjectedCoordinates) { return default; }
	public FTransform K2_GetTangentTransformAtECEFLocation(FVector ECEFCoordinates) { return default; }
	public void EngineToGeographic(FVector EngineCoordinates,FGeographicCoordinates GeographicCoordinates) {}
	public void GeographicToEngine(FGeographicCoordinates GeographicCoordinates,FVector EngineCoordinates) {}
	public void GetENUVectorsAtEngineLocation(FVector EngineCoordinates,FVector East,FVector North,FVector Up) {}
	public void GetENUVectorsAtGeographicLocation(FGeographicCoordinates GeographicCoordinates,FVector East,FVector North,FVector Up) {}
	public FTransform GetTangentTransformAtEngineLocation(FVector EngineCoordinates) { return default; }
	public FTransform GetTangentTransformAtGeographicLocation(FGeographicCoordinates GeographicCoordinates) { return default; }
	public FTransform GetPlanetCenterTransform() { return default; }
	public bool IsCRSStringValid(string CRSString,string Error) { return default; }
	public double GetGeographicEllipsoidMaxRadius() { return default; }
	public double GetGeographicEllipsoidMinRadius() { return default; }
	public double GetProjectedEllipsoidMaxRadius() { return default; }
	public double GetProjectedEllipsoidMinRadius() { return default; }
	public void ApplySettings() {}
	public EPlanetShape PlanetShape;
	public string ProjectedCRS;
	public string GeographicCRS;
	public bool bOriginAtPlanetCenter;
	public bool bOriginLocationInProjectedCRS;
	public double OriginLatitude;
	public double OriginLongitude;
	public double OriginAltitude;
	public double OriginProjectedCoordinatesEasting;
	public double OriginProjectedCoordinatesNorthing;
	public double OriginProjectedCoordinatesUp;
}
