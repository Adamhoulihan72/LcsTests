// ------------------------------------------------------------------------------------------------------------------------
// <copyright file="LcsController.cs" company="">
//   
// </copyright>
// <summary>
//   The lcs controller.
// </summary>
// ------------------------------------------------------------------------------------------------------------------------
namespace lcsFirstSteps.Controllers
{
    using System;
    using System.Web.Mvc;

    using lcsFirstSteps.Models;

    /// <summary>The lcs controller.</summary>
    public class LcsController : Controller
    {
        // GET: Lcs
        /// <summary>The index.</summary>
        /// <returns>The <see cref="ActionResult" />.</returns>
        public ActionResult Index()
        {
            return View(new Person { Age = 15, DateOfBirth = new DateTime(2001, 1, 2, 14, 43, 00), FirstName = "FirstName", LastName = "LastName" });
        }

        public ActionResult Display(Person model)
        {
            var data = model ??
                       new Person
                       {
                           Age = 15,
                           DateOfBirth = new DateTime(2001, 1, 2, 14, 43, 00),
                           FirstName = "Empty data",
                           LastName = "Empty Data"
                       };
            return View(data);
        }
    }
}