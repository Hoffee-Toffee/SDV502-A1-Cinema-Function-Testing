using System;
using CinemaApp;
using NUnit.Framework;

namespace CinemaAppUnitTesting;

class CinemaAppTest
{
    // Get all the functions from the CinemaApp class
    CinemaApp cinemaApp = new CinemaApp();

    // Test the AdultBefore5 function
    [Test]
    public void TestAdultBefore5()
    {
        // Test 1
        //  - Arrange
        int quantity = 1;
        string person = "Adult";
        string day = "Monday";
        decimal time = 4m;
        decimal expected = -1m;

        //  - Act
        decimal actual = cinemaApp.AdultBefore5(quantity, person, day, time);

        //  - Assert
        Assert.AreEqual(expected, actual);

        // Test 2
        quantity = 1;
        person = "Adult";
        day = "Monday";
        time = 5m;
        expected = 15m;

        actual = cinemaApp.AdultBefore5(quantity, person, day, time);
        Assert.AreEqual(expected, actual);

        // Test 3
        quantity = 2;
        person = "Adult";
        day = "Monday";
        time = 5m;
        expected = 30m;

        actual = cinemaApp.AdultBefore5(quantity, person, day, time);
        Assert.AreEqual(expected, actual);

        // Test 4
        quantity = 1;
        person = "Child";
        day = "Monday";
        time = 5m;
        expected = -1m;

        actual = cinemaApp.AdultBefore5(quantity, person, day, time);
        Assert.AreEqual(expected, actual);

        // Test 5
        quantity = 1;
        person = "Adult";
        day = "Tuesday";
        time = 5m;
        expected = -1m;

        actual = cinemaApp.AdultBefore5(quantity, person, day, time);
        Assert.AreEqual(expected, actual);

        // Test 6
        quantity = 1;
        person = "Adult";
        day = "Monday";
        time = 6m;
        expected = -1m;

        actual = cinemaApp.AdultBefore5(quantity, person, day, time);
        Assert.AreEqual(expected, actual);
    }

    // Test the AdultAfter5 function
    [Test]

    public void TestAdultAfter5()
    {
        // Test 1
        //  - Arrange
        int quantity = 1;
        string person = "Adult";
        string day = "Monday";
        decimal time = 4m;
        decimal expected = -1m;

        //  - Act
        decimal actual = cinemaApp.AdultAfter5(quantity, person, day, time);

        //  - Assert
        Assert.AreEqual(expected, actual);

        // Test 2
        quantity = 1;
        person = "Adult";
        day = "Monday";
        time = 5m;
        expected = 18m;

        actual = cinemaApp.AdultAfter5(quantity, person, day, time);
        Assert.AreEqual(expected, actual);

        // Test 3
        quantity = 2;
        person = "Adult";
        day = "Monday";
        time = 5m;
        expected = 36m;

        actual = cinemaApp.AdultAfter5(quantity, person, day, time);
        Assert.AreEqual(expected, actual);

        // Test 4
        quantity = 1;
        person = "Child";
        day = "Monday";
        time = 5m;
        expected = -1m;

        actual = cinemaApp.AdultAfter5(quantity, person, day, time);
        Assert.AreEqual(expected, actual);

        // Test 5
        quantity = 1;
        person = "Adult";
        day = "Tuesday";
        time = 5m;
        expected = -1m;

        actual = cinemaApp.AdultAfter5(quantity, person, day, time);
        Assert.AreEqual(expected, actual);

        // Test 6
        quantity = 1;
        person = "Adult";
        day = "Monday";
        time = 6m;
        expected = -1m;

        actual = cinemaApp.AdultAfter5(quantity, person, day, time);
        Assert.AreEqual(expected, actual);
    }

    // Test the AdultTuesday function
    [Test]

    public void TestAdultTuesday()
    {
        // Test 1
        //  - Arrange
        int quantity = 1;
        string person = "Adult";
        string day = "Monday";
        decimal expected = -1m;

        //  - Act
        decimal actual = cinemaApp.AdultTuesday(quantity, person, day);

        //  - Assert
        Assert.AreEqual(expected, actual);

        // Test 2
        quantity = 1;
        person = "Adult";
        day = "Tuesday";
        expected = 14m;

        actual = cinemaApp.AdultTuesday(quantity, person, day);
        Assert.AreEqual(expected, actual);

        // Test 3
        quantity = 2;
        person = "Adult";
        day = "Tuesday";
        expected = 28m;

        actual = cinemaApp.AdultTuesday(quantity, person, day);
        Assert.AreEqual(expected, actual);

        // Test 4
        quantity = 1;
        person = "Child";
        day = "Tuesday";
        expected = -1m;

        actual = cinemaApp.AdultTuesday(quantity, person, day);
        Assert.AreEqual(expected, actual);

        // Test 5
        quantity = 1;
        person = "Adult";
        day = "Monday";
        expected = -1m;

        actual = cinemaApp.AdultTuesday(quantity, person, day);
        Assert.AreEqual(expected, actual);
    }

    // Test the ChildUnder16 function
    [Test]
    
    public void TestChildUnder16()
    {
        // Test 1
        //  - Arrange
        int quantity = 0;
        string person = "Child";
        decimal expected = -1m;

        //  - Act
        decimal actual = cinemaApp.ChildUnder16(quantity, person);

        //  - Assert
        Assert.AreEqual(expected, actual);

        // Test 2
        quantity = 1;
        person = "Child";
        expected = 12m;

        actual = cinemaApp.ChildUnder16(quantity, person);
        Assert.AreEqual(expected, actual);

        // Test 3
        quantity = 2;
        person = "Child";
        expected = 24m;

        actual = cinemaApp.ChildUnder16(quantity, person);
        Assert.AreEqual(expected, actual);

        // Test 4
        quantity = 1;
        person = "Adult";
        expected = -1m;

        actual = cinemaApp.ChildUnder16(quantity, person);
        Assert.AreEqual(expected, actual);
    }

    // Test the Senior function

    [Test]

    public void TestSenior()
    {
        // Test 1
        //  - Arrange
        int quantity = 0;
        string person = "Senior";
        decimal expected = -1m;

        //  - Act
        decimal actual = cinemaApp.Senior(quantity, person);

        //  - Assert
        Assert.AreEqual(expected, actual);

        // Test 2
        quantity = 1;
        person = "Senior";
        expected = 12m;

        actual = cinemaApp.Senior(quantity, person);
        Assert.AreEqual(expected, actual);

        // Test 3
        quantity = 2;
        person = "Senior";
        expected = 24m;

        actual = cinemaApp.Senior(quantity, person);
        Assert.AreEqual(expected, actual);

        // Test 4
        quantity = 1;
        person = "Adult";
        expected = -1m;

        actual = cinemaApp.Senior(quantity, person);
        Assert.AreEqual(expected, actual);
    }

    // Test the Student function
    [Test]

    public void TestStudent()
    {
        // Test 1
        //  - Arrange
        int quantity = 0;
        string person = "Student";
        decimal expected = -1m;

        //  - Act
        decimal actual = cinemaApp.Student(quantity, person);

        //  - Assert
        Assert.AreEqual(expected, actual);

        // Test 2
        quantity = 1;
        person = "Student";
        expected = 12m;

        actual = cinemaApp.Student(quantity, person);
        Assert.AreEqual(expected, actual);

        // Test 3
        quantity = 2;
        person = "Student";
        expected = 24m;

        actual = cinemaApp.Student(quantity, person);
        Assert.AreEqual(expected, actual);

        // Test 4
        quantity = 1;
        person = "Adult";
        expected = -1m;

        actual = cinemaApp.Student(quantity, person);
        Assert.AreEqual(expected, actual);
    }

    // Test the FamilyPass function
    [Test]

    public void testFamilyPass()
    {
        // Test 1
        //  - Arrange
        int quantity_ticket = 1;
        int quantity_child = 2;
        int quantity_adult = 2;
        decimal expected = 49m;

        //  - Act
        decimal actual = cinemaApp.FamilyPass(quantity_ticket, quantity_child, quantity_adult);

        //  - Assert
        Assert.AreEqual(expected, actual);

        // Test 2

        quantity_ticket = 1;
        quantity_child = 1;
        quantity_adult = 1;
        expected = -1m;

        actual = cinemaApp.FamilyPass(quantity_ticket, quantity_child, quantity_adult);
        Assert.AreEqual(expected, actual);

        // Test 3

        quantity_ticket = 1;
        quantity_child = 3;
        quantity_adult = 2;
        expected = -1m;

        actual = cinemaApp.FamilyPass(quantity_ticket, quantity_child, quantity_adult);
        Assert.AreEqual(expected, actual);

        // Test 4

        quantity_ticket = 1;
        quantity_child = 3;
        quantity_adult = 1;
        expected = 49m;

        actual = cinemaApp.FamilyPass(quantity_ticket, quantity_child, quantity_adult);
        Assert.AreEqual(expected, actual);
    }

    // Test the ChickFlickThursday function
    [Test]

    public void TestChickFlickThursday()
    {
        // Test 1
        //  - Arrange
        int quantity = 1;
        string person = "Adult";
        string day = "Monday";
        decimal expected = -1m;

        //  - Act
        decimal actual = cinemaApp.ChickFlickThursday(quantity, person, day);

        //  - Assert
        Assert.AreEqual(expected, actual);

        // Test 2
        quantity = 1;
        person = "Adult";
        day = "Thursday";
        expected = 14m;

        actual = cinemaApp.ChickFlickThursday(quantity, person, day);
        Assert.AreEqual(expected, actual);

        // Test 3
        quantity = 2;
        person = "Adult";
        day = "Thursday";
        expected = 28m;

        actual = cinemaApp.ChickFlickThursday(quantity, person, day);
        Assert.AreEqual(expected, actual);

        // Test 4
        quantity = 1;
        person = "Child";
        day = "Thursday";
        expected = -1m;

        actual = cinemaApp.Chick_Flick_Thursday(quantity, person, day);
        Assert.AreEqual(expected, actual);

    }
    
    // Test the Kids_Careers function
    [Test]

    public void TestKids_Careers()
    {
        // Test 1
        //  - Arrange
        int quantity = 1;
        string person = "Adult";
        string day = "Monday";
        bool isHoliday = false;
        decimal expected = -1m;

        //  - Act

        decimal actual = cinemaApp.Kids_Careers(quantity, person, day, isHoliday);

        //  - Assert

        Assert.AreEqual(expected, actual);

        // Test 2

        quantity = 1;
        person = "Adult";
        day = "Wednesday";
        isHoliday = true;
        expected = -1m;

        actual = cinemaApp.Kids_Careers(quantity, person, day, isHoliday);
        Assert.AreEqual(expected, actual);

        // Test 3

        quantity = 1;
        person = "Child";
        day = "Wednesday";
        isHoliday = true;
        expected = 12m;

        actual = cinemaApp.Kids_Careers(quantity, person, day, isHoliday);
        Assert.AreEqual(expected, actual);

        // Test 4

        quantity = 2;
        person = "Child";
        day = "Wednesday";
        isHoliday = true;
        expected = 24m;

        actual = cinemaApp.Kids_Careers(quantity, person, day, isHoliday);
        Assert.AreEqual(expected, actual);

    }
}
