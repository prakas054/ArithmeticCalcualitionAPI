using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticCalcualitonAPI.Controllers;
using ArithmeticCalcualitonAPI.Calculation;

namespace ArithmeticCalcualitonAPI.Tests
{
    /// <summary>
    /// Summary description for TestOperationController
    /// </summary>
    [TestClass]
    public class TestOperationController
    {
        private readonly OperationController _OperationController;
        private IAddModel _IAddModel;
        private IDifferenceModel _IDifferenceModel;
        private IProductModel _IProductModel;
        private IDivideModel _IDivideModel;
        public TestOperationController()
        {


            _OperationController = new OperationController(_IAddModel, _IDifferenceModel, _IProductModel, _IDivideModel);
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void add()
        {
           // intn
         //   var addtest= _OperationController(_IAddModel);
            //
            // TODO: Add test logic here
            //
        }
    }
}
