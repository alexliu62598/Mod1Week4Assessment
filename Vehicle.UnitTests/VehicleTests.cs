namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        // This test needs some work!
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");

            var expected = "This Blue vehicle has 2 wheels and has driven 0 miles";

            Assert.Equal(expected, andysBike.Summary());
        }

        // Add more tests here!

        [Fact]
        public void NumberOfWheelsProperty_CanBeRetrieved()
        {
            var alexsCar = new Vehicle(4, "Black");

            Assert.Equal(4, alexsCar.NumberOfWheels);
        }

        [Fact]
        public void ColorProperty_CanBeRetrieved()
        {
            var alexsCar = new Vehicle(4, "Black");

            Assert.Equal("Black", alexsCar.Color);
        }

        [Fact]
        public void MilesDrivenProperty_CanBeRetrieved()
        {
            var alexsCar = new Vehicle(4, "Black");

            Assert.Equal(0, alexsCar.MilesDriven);
        }


        [Fact]
        public void Drive_AddstoMilesDriven()
        {
            var alexsCar = new Vehicle(4, "Black");

            var expected = 5;

            alexsCar.Drive();

            Assert.Equal(expected, alexsCar.MilesDriven);

        }

        [Fact]
        public void Paint_ReassignsColorProperty()
        {
            var alexsCar = new Vehicle(4, "Black");

            alexsCar.Paint("Brown");

            Assert.Equal("Brown", alexsCar.Color);
        }
    }
}