using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoListMvc.Models;
using System.Collections.Generic;
using System;

namespace ToDoListMvc.Tests
{
  [TestClass]
  public class CategoryTest
  {
    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {
      Category newCategory = new Category("test category");
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Category";
      Category newCategory = new Category(name);
      string result = newCategory.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      string name = "Test Category";
      Category newCategory = new Category(name);
      int result = newCategory.Id;
      Assert.AreEqual(3, result);
    }
  }
}