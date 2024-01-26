using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week3_ObjectOrientedProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Week3_ObjectOrientedProgramming.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        [TestMethod()]
        public void VehicleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DriveTestSuccessful()
        {
            // AAA convention

            // Arrange - setup the variables we need for testing
            double expectedLitersInTank = 4.2;
            double expectedOdometerKilometers = 8;
            Vehicle vehicle = new Vehicle("", "", "", 10, 5);
            vehicle.AddGas(5);

            // Act - call the code we're testing and get values
            bool result = vehicle.Drive(expectedOdometerKilometers);
            double actualLitersInTank = vehicle.LitersInTank;
            double actualOdometerKilometers = vehicle.OdometerReadingInKilometers;

            // Assesrt - did we get what we expected
            Assert.AreEqual(expectedLitersInTank, actualLitersInTank);
            Assert.IsTrue(result);
            Assert.AreEqual(expectedOdometerKilometers, actualOdometerKilometers);
        }

        [TestMethod()]
        public void DriveTestUnsuccessful()
        {
            // AAA convention

            // Arrange - setup the variables we need for testing
            double expectedLitersInTank = 0;
            double expectedOdometerKilometers = 0;
            Vehicle vehicle = new Vehicle("", "", "", 10, 5);

            // Act - call the code we're testing and get values
            bool result = vehicle.Drive(expectedOdometerKilometers);
            double actualLitersInTank = vehicle.LitersInTank;
            double actualOdometerKilometers = vehicle.OdometerReadingInKilometers;

            // Assesrt - did we get what we expected
            Assert.AreEqual(expectedLitersInTank, actualLitersInTank);
            Assert.IsTrue(result);
            Assert.AreEqual(expectedOdometerKilometers, actualOdometerKilometers);
        }

        [TestMethod()]
        public void AddGasTestSuccessful()
        {
            // AAA convention

            // Arrange - setup the variables we need for testing
            double expectedLitersInTank = 4.2;
            Vehicle vehicle = new Vehicle("", "", "", 0, 5);

            // Act - call the code we're testing and get values
            bool result = vehicle.AddGas(expectedLitersInTank);
            double actualLitersInTank = vehicle.LitersInTank;

            // Assesrt - did we get what we expected
            Assert.AreEqual(expectedLitersInTank, actualLitersInTank);
            Assert.IsTrue(result);

        }

        [TestMethod()]
        public void AddGasTestUnsuccessful()
        {
            // AAA convention

            // Arrange - setup the variables we need for testing
            double expectedLitersInTank = 0;
            Vehicle vehicle = new Vehicle("", "", "", 0, 0);

            // Act - call the code we're testing and get values
            bool result = vehicle.AddGas(5);
            double actualLitersInTank = vehicle.LitersInTank;

            // Assesrt - did we get what we expected
            Assert.AreEqual(expectedLitersInTank, actualLitersInTank);
            Assert.IsFalse(result);

        }
    }
}