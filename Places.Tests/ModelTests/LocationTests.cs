using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace Place.Tests
{
  [TestClass]
  public class LocationTests : IDisposable
  {

    public void Dispose()
    {
      Location.ClearAll();
    }

    [TestMethod]
    public void LocationConstructor_CreatesInstanceOfLocation_Location()
    {
      Location newLocation = new Location("test");
      Assert.AreEqual(typeof(Location), newLocation.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";

      //Act
      Location newLocation = new Location(description);
      string result = newLocation.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Location newLocation = new Location(description);

      //Act
      string updatedDescription = "Do the dishes";
      newLocation.Description = updatedDescription;
      string result = newLocation.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_LocationList()
    {
      // Arrange
      List<Location> newList = new List<Location> { };

      // Act
      List<Location> result = Location.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsLocations_LocationList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Location newLocation1 = new Location(description01);
      Location newLocation2 = new Location(description02);
      List<Location> newList = new List<Location> { newLocation1, newLocation2 };

      //Act
      List<Location> result = Location.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_LocationsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string description = "Walk the dog.";
      Location newLocation = new Location(description);

      //Act
      int result = newLocation.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectLocation_Location()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Location newLocation1 = new Location(description01);
      Location newLocation2 = new Location(description02);

      //Act
      Location result = Location.Find(2);

      //Assert
      Assert.AreEqual(newLocation2, result);
    }
    
  }
}