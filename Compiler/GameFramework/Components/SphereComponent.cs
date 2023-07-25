using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("Components/SphereComponent.h")]
    public partial class USphereComponent : UShapeComponent {
        public void InitSphereRadius(float InSphereRadius) { }
        public float SphereRadius;
    }

}