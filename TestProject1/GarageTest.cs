using Ovning5_Garage1._0;

namespace TestProject1
{
    public class GarageTest
    {
        //Testa Garagekonstruktorn
        [Fact]
        public void Garage_PositiveNumberAsCapacityOfGarage_CreatesGarageWithCorrectCapacity()
        {
            // Arrange
            int expectedCapacity = 20;

            // Act
            Garage<Vehicle> garage = new Garage<Vehicle>(expectedCapacity);

            // Assert
            Assert.Equal(expectedCapacity, garage.Capacity);
        }


        //Testa Park(T vehicle)
        [Fact]
        public void Park_ParkOneVehicleInEmptyGarage_OneVehicleParked()
        {
            // Arrange
            Garage<Vehicle> garage = new Garage<Vehicle>(10);
            Vehicle vehicle = new Car("abc123", "brand", 1988, "color", 4, "bensin");

            //Act
            garage.Park(vehicle);

            //Assert
            Assert.Single(garage);
        }


        //Testa UnPark(T found)
        [Fact]
        public void UnPark_UnparkOneVehicleFromGarageWithOneVehicle_GarageEmpty()
        {
            // Arrange
            Garage<Vehicle> garage = new Garage<Vehicle>(10);
            Vehicle vehicle = new Car("abc123", "brand", 1988, "color", 4, "bensin");
            garage.Park(vehicle);

            //Act
            garage.UnPark(vehicle);

            //Assert
            Assert.Empty(garage);
        }
    }
}